<template>
  <Navbar />
  <router-view/>
  <Footer />
</template>

<script>
import Navbar from './components/Navbar.vue'
import Footer from './components/Footer.vue'
export default {
  components: {
    Navbar,
    Footer
  }
}
</script>

<style>
*{
  margin: 0;
  padding: 0;
  font-family: Verdana, Geneva, Tahoma, sans-serif;
}
</style>
