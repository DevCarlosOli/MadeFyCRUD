<template>
    <div class="container-fluid">
        <div class="row align-items-center">
            <h1 id="sobreMim">{{ msg }}</h1>
            <div class="col-sm-8">
                <TextoSobreMim />
            </div>
            <div class="col-sm-4 text-center">
                <img class="img-fluid " src="../../assets/eu01.png" alt="Este sou eu">
            </div>
        </div>
        <Skills />
    </div>
</template>

<script>
import TextoSobreMim from './TextoSobreMim.vue'
import Skills from './Skills.vue'

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

<style>
#sobreMim{
    text-align: center;
}
</style>