<template>
    <div id="pet-list">
        <ul>
            <li v-for="pet in pets" :key="pet.name">
                <Pet :name="pet.name "></Pet>
            </li>
        </ul>
        <div>
            <form>
                <input type="text" placeholder="Pet to spawn" v-model="newPetName"/><button v-on:click="spawnPet">Spawn</button>
            </form>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'
    import Pet from './Pet/Pet.vue'

    export default {
        name: 'PetList',
        components: {
            Pet
        },
        props: {
            newPetName: String
        },
        methods: {
            spawnPet: function (event) {
                event.preventDefault();
                axios
                    .get('api/pet/add', {
                        params: {
                            petName: this.newPetName
                        }
                    })
                    .then(response => ((alert(response.data)))
                    );
            }
        },
        created() {
            axios
                .get('api/pet/list');
        }
    };

</script>

