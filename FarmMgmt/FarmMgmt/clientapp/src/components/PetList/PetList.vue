<template>
    <div id="pet-list">
        <div class="input-group mb-3">
            <input type="text" class="form-control" placeholder="Name a pet to spawn" v-model="newPetName"
                   aria-label="Name a pet to spawn" aria-describedby="button-addon2">
            <div class="input-group-append">
                <button class="btn btn-outline-primary" type="button" id="button-addon2" v-on:click.self.prevent="spawnPet">Spawn</button>
            </div>
        </div>
        <div>
            <h5>Pets on farm already:</h5>
            <Pet v-for="pet in pets" :key="pet.name" :name="pet.name" v-on:userRemovingPet="onPetRemoving"></Pet>
        </div>
    </div>
</template>

<script>
    import axios from 'axios'
    import swal from 'sweetalert2'
    import Pet from './Pet/Pet.vue'


    export default {
        name: 'PetList',
        components: {
            Pet
        },
        props: {
            newPetName: String
        },
        data() {
            return {
                pets: []
            }
        },
        methods: {
            spawnPet() {
                axios
                    .get('api/pet/add', {
                        params: {
                            petName: this.newPetName
                        }
                    })
                    .then(() => {
                        this.pets.push({ name: this.newPetName });
                        this.newPetName = "";
                    })
                    .catch(() => {
                        swal.fire("Cannot add " + this.newPetName + ". May be it already are walking on your farm?");
                    })
            },
            onPetRemoving(removingPetName) {
                axios.get('api/pet/remove', {
                    params: {
                        petName: removingPetName
                    }
                })
                    .then(() => {
                        this.pets = this.pets.filter(function (pet) { return pet.name != removingPetName });
                    })
                    .catch(() => {
                        swal.fire("Cannot remove " + removingPetName + ". May be is does not exist? Check it.");
                })
            },
            refreshPets() {
                axios
                    .get('api/pet/list')
                    .then(response => (this.pets = response.data))
                    .catch(() => {
                        swal.fire("Error with connection to backend API...");
                    })
            }
        },
        mounted() {
            this.refreshPets();
        }
    }

</script>

<style scoped>
#pet-list {
    padding: 0;
    margin-bottom: 60px;
    margin-top: 20px;
}
.input-group {
    margin-top: 10px;
    max-width:400px;
    display: inline-flex;
}
</style>