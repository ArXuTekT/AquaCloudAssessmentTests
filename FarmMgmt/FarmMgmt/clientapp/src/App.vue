<template>
  <div id="app">
    <Header title="Farm Manager" subtitle="Manage animals from home"/>
    <PetList></PetList>
  </div>
</template>

<script>
    import Header from './components/Header.vue';
    import PetList from './components/PetList/PetList.vue';

    export default {
      name: 'app',
      components: {
          Header,
          PetList
      }
    }
</script>

<style>
#app {
  font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 10px;
  margin-left: 20%;
  margin-right: 20%;
}
</style>
