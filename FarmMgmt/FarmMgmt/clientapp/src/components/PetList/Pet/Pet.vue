<template>
    <div class="btn-group pet" role="group" aria-label="Pet">
        <button type="button" class="btn btn-warning">{{ name }}</button>
        <button type="button" class="btn btn-danger" v-on:click="removePet" aria-label="Slay">
            <i class="bi bi-type-strikethrough" title="Slay"></i>
        </button>
    </div>
</template>

<script>
export default {
    name: 'Pet',
    props: {
        name: String
        },
        data() {
            return {
                buttonId: this.name.replace(/\s+/g, '') + "-btn"
            }
        },
    methods: {
        removePet() {
            this.$emit("userRemovingPet", this.name);
      }
    }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.pet{
    padding: 8px;
}
</style>
