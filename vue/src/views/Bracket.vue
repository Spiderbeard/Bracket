<template>
  <create-bracket v-bind:numberOfParticipants=this.$store.numberOfParticipants />


</template>

<script>
import CreateBracket from '../components/CreateBracket'

export default {
  components: { CreateBracket },

}
</script>

<style>

</style>