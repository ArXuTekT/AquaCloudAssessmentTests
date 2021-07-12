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
                axios.get('api/pet/add', {
                    petName: 'MYDAK'
                });
            }
        }
    }
    //var petList = new Vue({
    //    el: '#pet-list',
    //    data: {
    //        pets: []
    //    }
    //})
</script>

