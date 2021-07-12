<template>
    <div class="header">
        <h1>{{ title }}</h1>
        <img id="logo" alt="Farm Manager logo" src="../assets/logo.png">
        <h3>{{ subtitle }}</h3>
    </div>
</template>

<script>
export default {
  name: 'Header',
  props: {
      title: String,
      subtitle: String
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
#logo {
    max-height: 80px;
}
h3 {
    font-family: Arial, Helvetica, sans-serif;
  margin: 40px 0 0;
}
    h1 {
        margin-bottom: 10px;
        color: #b96f30;
    }
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
