<template>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
            <router-link to="/" class="navbar-brand">{{ nameFull }}</router-link>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarText">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <router-link to="/sobreMim" class="nav-link active">Sobre Mim</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link to="/blog" class="nav-link">Blog</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link to="/portifolio" class="nav-link">Portifólio</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link to="/contato" class="nav-link">Contato</router-link>
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

<style scoped>
.mediaSocial{
    margin-left: 10px;
}
#navbarText a{
    color: white;
}
</style>