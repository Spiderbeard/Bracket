<template>
  <div>
    <div>
      <div v-bind:class="`box ` + roundby + length">
        <div v-bind:class="`forkbox ` + roundby + roundbyline + length">
          <div v-bind:class="`topbox ` + roundbyline + length"></div>
          <div v-bind:class="`bottombox ` + roundby + location + length"></div>
        </div>
        <div v-bind:class="`linebox ` + roundbyline + location + length">
          <div class="line2"></div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ["roundby", "roundbyline", "length", "location"],
};
</script>

<style>
.box {
  display: flex;
  flex-direction: row;
}

.forkbox {
  display: flex;
  flex-direction: column;
  width: 67%;
}

.topbox {
  border: 2px hidden;
  height: 80px;
  width: 20%;
}

.bottombox {
  border: 2px solid black;
  border-top: 0px;
  border-left: 0px;
  height: 80px;
  width: 100%;
}

.line2 {
  display: flex;
  border: 2px solid black;
  width: 100%;
  height: 0%;
}

.linebox {
  display: flex;
  width: 33%;
  align-items: center;
}
.twoby10 {
  margin-top: 32px;
}
.twoby210 {
  height: 42px;
}
.twolineby10 {
  height: 51px;
}
.twolineby210 {
  margin-top: 15px;
}

.twobytwolineby10 {
  margin-top: 4px;
  width: 75%;
  height: 100px;
}

.twoby212 {
  height: 67px;

  width: 102%;
}
.twolineby212 {
  margin-top: 16px;
}
.threebythreelineby12 {
  height: 114px;
  margin-top: 10px;
}
.threelineby112 {
  margin-top: 16px;
}
.threeby112 {
  width: 100%;
}

.twoby313 {
  height: 55px;
}
.twolineby13 {
  height: 85px;
}
.twolineby313 {
  margin-top: 35px;
}
.threelineby11 {
  height: 73px;
}
.threeby111 {
  height: 50px;
}
.threelineby111 {
  margin-top: 27px;
}
.threeby110 {
  height: 60px;
}
.threelineby110 {
  margin-top: 27px;
}
.twolineby29 {
  margin-top: 34px;
}
.twolineby9 {
  height: 88px;
}
.twoby29 {
  height: 61px;
}
.threeby19 {
  height: 61px;
}
.threelineby19 {
  margin-top: 24px;
}
.twolineby6 {
  height: 86px;
}
.twoby16 {
  height: 58px;
}
.twolineby16 {
  margin-top: 32px;
}
.twolineby5 {
  height: 86px;
}
.twoby15 {
  height: 73px;
}
.twolineby15 {
  margin-top: 17px;
}
.twoby314 {
  height: 30px;
}
.twolineby14 {
  height: 89px;
}
.twolineby314 {
  margin-top: 63px;
}
</style>
