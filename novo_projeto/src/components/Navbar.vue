<template>
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark">
        <div class="container-fluid">
            <router-link to="/" class="navbar-brand">{{ nameFull }}</router-link>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarText">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <router-link class="nav-link" to="/">Home</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/sobreMim">Sobre Mim</router-link>
                    </li>
                    <li class="nav-item">
                        <router-link class="nav-link" to="/portfolio">Portfolio</router-link>
                    </li>
                </ul>
                <div class="mediaSocial">
                    <a id="whatsapp" href="https://web.whatsapp.com/send?phone=5562992067458" target="_blank"><i class='fab fa-whatsapp' style='font-size:48px;'></i></a>
                    <a id="email" href="mailto:c.oliveiradev@gmail.com?subject=Contato"><i class='fa fa-envelope' style='font-size:48px;'></i></a>
                    <a id="linkedin" href="https://www.linkedin.com/in/carlos-r-de-oliveira-filho-62a996200/" target="_blank"><i class='fab fa-linkedin' style='font-size:48px;'></i></a>
                    <a id="github" href="https://github.com/DevCarlosOli" target="_blank"><i class='fab fa-github' style='font-size:48px;'></i></a>
                </div>                
            </div>            
        </div>        
    </nav>
</template>

<script>


export default {
    name: "Navbar",
    data() {
        return {
            nameFull: 'Carlos Oliveira'
        }
    },
}
</script>

<style scoped>
.mediaSocial a{
    margin-left: 15px;
    color: #fff;
}
.mediaSocial #whatsapp:hover{
    color: rgb(51, 190, 137);
    transition: 0.5s;
}
.mediaSocial #email:hover{
    color: rgb(206, 44, 44);
    transition: 0.5s;
}
.mediaSocial #linkedin:hover{
    color: rgb(51, 100, 190);
    transition: 0.5s;
}
.mediaSocial #github:hover{
    color: rgb(140, 77, 223);
    transition: 0.5s;
}
</style>
  