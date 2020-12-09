<template>
  <div class="home">
    <h1>Home</h1>
    <p>You must be authenticated to see this</p>
    <sidenav />
  </div>
</template>

<script>
import sidenav from "@/components/sidenav";

export default {
  components: { sidenav },
  name: "home",

  created(){
    this.$store.commit("UPDATE_PARTICIPANTS",0)
  },
                                
};
</script>
