<template>
    <nav class="navbar navbar-expand-lg bg-body-tertiary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">{{ nameFull }}</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarText">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" href="#">Sobre Mim</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Portifólio</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Contato</a>
                    </li>
                </ul>
                <a class="mediaSocial" href="https://www.linkedin.com/in/carlos-r-de-oliveira-filho-62a996200/" target="_blank"><i class='fab fa-linkedin' style='font-size:48px;'></i></a>
                <a class="mediaSocial" href="https://github.com/DevCarlosOli" target="_blank"><i class='fab fa-github' style='font-size:48px;'></i></a>
            </div>
        </div>
    </nav>
</template>

<script>
export default {
    name: 'Header',
    data() {
        return {
            nameFull: 'Carlos Oliveira',
            job: 'Analista Desenvolvedor'
        }
    },
}
</script>

<style>
.mediaSocial{
    margin-left: 10px;
}
#navbarText a{
    color: black;
}
</style>