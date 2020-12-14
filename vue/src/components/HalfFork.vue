<template>
  <div>
    <div>
      <div class="box">
        <div class="forkbox">
          <div class="topbox"></div>
          <div class="bottombox"></div>
        </div>
        <div class="linebox">
          <div class="line"></div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {};
</script>

<style>
.box {
  display: flex;
  flex-direction: row;
}

.forkbox {
  display: flex;
  flex-direction: column;
  width: 20%;
}

.topbox {
  border: 2px hidden;
  height: 80px;
  width: 20%;
}

.bottombox {
  border: 4px solid black;
  border-top: 0px;
  border-left: 0px;
  height: 80px;
  width: 97%;
}

.line {
  display: flex;
  border: 2px solid black;
  width: 100%;
  height: 0%;
}

.linebox {
  display: flex;
  width: 5%;
  align-items: center;
}
</style>
