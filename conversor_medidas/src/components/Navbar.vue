<template>
    <nav class="navbar">
        <div class="container">
            <router-link id="name" class="navbar-brand" to="/">{{ name }}</router-link>
            <DarkModeButton :mode="mode" @toggle="$emit('toggle')"/>
        </div>
    </nav>
</template>

<script>
    import DarkModeButton from './DarkModeButton.vue'

    export default {
        data() {
            return {
            name: 'CONVERSOR DE MEDIDAS'
            }
        },
        components: {
            DarkModeButton
        },
        props: ['mode']
    }
</script>

<style scoped>
    .navbar{
        background: #c3c3c3;
        transition: 0.3s ease-in-out;
    }

    .dark nav{
        background: #15202B;
    }

    #name{
        margin: 0 auto;
        color: #d1d1d1;
        font-weight: bold;
    }

    #name::before{
        content: "CONVERSOR DE MEDIDAS";
        color: #222;
        position: absolute;
        width: 150px;
        overflow: hidden;
        white-space: nowrap;
        border-right: 2px solid #222;
        animation: animate 8s linear infinite;
    }

    .dark #name::before{
        color: #faeb13;
        border-right: 2px solid #faeb13;
    }

    /* KeyFrames */
    @keyframes animate{
        0%, 10%, 100%{
            width: 0;
        }

        70%, 90%{
            width: 240px;
        }
    }
</style>
