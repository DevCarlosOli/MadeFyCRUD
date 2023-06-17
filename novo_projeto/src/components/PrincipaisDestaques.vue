<template>
    <div class="container-fluid mt-3">
        <div class="row">
            <h4>Principais Destaques</h4>
            <div class="col-sm d-flex flex-wrap justify-content-around">
                <div class="col-sm-4 d-flex flex-wrap justify-content-center p-2 conteudo-portfolio">
                    <div class="img-portfolio"></div>
                    <p>Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                </div>
                <div class="col-sm-4 d-flex flex-wrap justify-content-center p-2 conteudo-portfolio">
                    <div class="img-portfolio"></div>
                    <p>Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                </div>
                <div class="col-sm-4 d-flex flex-wrap justify-content-center p-2 conteudo-portfolio">
                    <div class="img-portfolio"></div>
                    <p>Sunt in culpa qui officia deserunt mollit anim id est laborum consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco.</p>
                </div>
            </div>            
        </div>
    </div>
</template>

<script>
export default {
    name: 'PrincipaisDestaques'
}
</script>

<style scoped>
    .conteudo-portfolio p{
        text-align: justify;
    }

    .img-portfolio{
        height: 300px;
        width: 450px;
        background-color: red;
        margin-top: 15px;
        border-radius: 8px;
    }

    @media only screen and (max-width: 500px) {
        .img-portfolio{
            width: 100%;
        }
    }
</style>