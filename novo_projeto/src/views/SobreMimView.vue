<template>
    <div class="container-fluid">
        <div class="row align-items-center">
            <h1 id="sobreMim">{{ msg }}</h1>
            <div class="col-sm-8">
                <TextoSobreMim />
            </div>
            <div class="col-sm-4 text-center">
                <img class="img-fluid " src="../../public/img/eu01.png" alt="Este sou eu">
            </div>
        </div>
        <Skills />
    </div>
</template>
  
<script>
    import TextoSobreMim from '../components/TextoSobreMim.vue'
    import Skills from '../components/Skills.vue'

    export default {
        name: 'SobreMim',
        data() {
            return {
                msg: 'Sobre Mim'
            }
        },
        components: {
            TextoSobreMim,
            Skills
        }
    }
</script>

<style scoped>
    #sobreMim{
        text-align: center;
        margin-top: 80px;
    }
</style>
  