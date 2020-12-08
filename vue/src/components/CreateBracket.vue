<template>
    <div>
        <ul>
           <li v-for="participant in this.$store.Participants" v-bind:key="participant.name">{{participant}} </li>
            <!-- TODO need to keep title of the bracket from the form , create form object , all we did was call participants pants, also JESS doesnt like the variable name, racheal loves it though nick and joe are the same page    -->
        </ul>

    </div>
</template>

<script>

export default {
    

}
</script>

<style>

</style>