<template>
        <div class="pet">
           <h4>{{ name }}</h4> <button v-on:click="removePet">Cast out</button>
        </div>
</template>

<script>
export default {
  name: 'Pet',
  props: {
      name: String
    },
  methods: {
      removePet: function () {
          alert('Removing ' + this.name);
      }
    }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
li {
  display: inline-block;
  margin: 0 10px;
}
</style>
