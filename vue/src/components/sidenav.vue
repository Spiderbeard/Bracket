<template>
    <form action="" >
      <div>
        <label for="Title">Title</label>
        <input type="text" placeholder="Enter Title">
      </div>
      <div>
        <label for="#ofthings">#placeholder</label>
        <select  v-model="selected" name="" id="" >
          <option v-for="option in options" v-bind:key="option">
            {{option}}
          </option> 
        </select>
      </div>
      <div>
        <button type="submit" @click.prevent="updatePants"/>
      </div>
    </form>
</template>

<script>
export default {
  
  data() {
    return {
    selected: '',
    options: [2,3,4,5,6,7,8,9,10,11,12,13,14,15,16],
    
    }
  },
  methods:{
    updatePants(){
      this.$store.commit('UPDATE_PARTICIPANTS',this.selected )
    }
  }

}
</script>

<style>

</style>