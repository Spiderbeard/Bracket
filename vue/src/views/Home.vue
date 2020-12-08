<template>
  <div class="home">
    <h1>Home</h1>
    <p>You must be authenticated to see this</p>
    <sidenav/>
    <create-bracket/>
  </div>
</template>

<script>
import sidenav from "@/components/sidenav"
import CreateBracket from '@/components/CreateBracket'


export default {
  components: { sidenav,CreateBracket },
  name: "home"
};

</script>
