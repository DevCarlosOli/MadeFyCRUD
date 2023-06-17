<template>
    <div id="banner-main" class="d-flex align-items-start flex-column">
        <span id="fundo-texto">
            <h1>Seja bem-vindo!</h1>
            <p>Sou <strong>Desenvolvedor .Net</strong>, apaixonado por jogos e tecnologia. Procuro sempre me especializar na área para poder melhorar minhas oportunidades de crescimento. Sou graduado em <strong>Análise e Desenvolvimento de Sistemas</strong> pela Unip e pós-graduado <strong>MBA - Engenharia de Software</strong> pela Faculdade Metropolitana. Principais conhecimentos: <strong>BoostStrap</strong>, <strong>JavaScript</strong>, <strong>Vue.js</strong>, <strong>C#</strong>, <strong>SQL</strong>, <strong>Git</strong>, <strong>SVN</strong>, <strong>CorelDRAW</strong>, <strong>PhotoShop</strong> </p>
        </span>
    </div>    
</template>

<script>
    export default {
        name: 'Banner'
    }
</script>

<style scoped>
    #banner-main{
        background-image: url('../../public/img/banner.png');
        background-position: 0 -180px;
        background-size: cover;
        background-repeat: no-repeat;
        height: 100vh;
        color: #fff;
        transition: ease 0.5s;
    }

    #banner-main h1{
        margin-left: 80px;
        margin-top: 130px;
        transition: ease 0.5s;
    }

    #banner-main p{
        margin-left: 45px;
        margin-top: 70px;
        width: 400px;
        text-align: justify;
        transition: ease 0.5s;
    }

    /* MediaQuery */
    @media only screen and (max-width: 1195px) {

        #banner-main h1{
            margin-left: 40px;
        }
        #banner-main p{
            margin-left: 25px;
            margin-top: 30px;
            width: 380px;
            text-align: justify;
        }
    }

    @media only screen and (max-width: 1090px) {

        #banner-main h1{
            margin-top: 80px;
        }
        #banner-main p{
            margin-left: 25px;
            margin-top: 10px;
            width: 350px;
            text-align: justify;
        }
    }

    @media only screen and (max-width: 960px) {
        #banner-main{
            background-size: 1000px;
        }
    }

    @media only screen and (max-width: 500px) {
        #banner-main{
            background-position: -400px -230px;
            background-size: 1000px;
            height: 60vh;
        }

        #fundo-texto{
            width: 100%;
            background-color: rgba(0, 0, 0, 0.7);
            height: 55vh;
        }

        #banner-main h1{
            margin-top: 100px;
            margin-left: 120px;
        }
        
        #banner-main p{
            margin-left: 25px;
            margin-top: 10px;
            width: 425px;
            text-align: justify;
        }
    }

    @media only screen and (max-width: 462px){        
        #banner-main h1{
            margin-left: 90px;
        }

        #banner-main p{
            margin-left: 25px;
            margin-top: 10px;
            width: 350px;
            text-align: justify;
        }
    }

    @media only screen and (max-width: 375px){
        #banner-main{
            background-position: -480px -130px;
        }
        
        #banner-main h1{
            margin-left: 90px;
        }

        #banner-main p{
            margin-left: 25px;
            margin-top: 10px;
            width: 320px;
            text-align: justify;
        }
    }
</style>