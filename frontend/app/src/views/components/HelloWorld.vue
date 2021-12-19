<template>
  <div class="hello">
    <h1>{{ message }}</h1>
    <p>Client username: {{ myUserName }}</p>
    <p>Greet from server: {{ greet }}</p>
  </div>
</template>

<script lang="ts">
import { HelloWorldService } from "@/services/HelloWorldService";
import { Component, Vue } from "vue-property-decorator";

@Component
export default class HelloWorld extends Vue {
  helloWorldService: HelloWorldService;

  greet = "";
  myUserName = "";

  constructor() {
    super();
    this.helloWorldService = new HelloWorldService();
  }

  created(): void {
    this.myUserName = "User_" + this.getRandomInt(100000);

    this.helloWorldService
      .greet(this.myUserName)
      .then((response) => {
        this.greet = response;
      })
      .catch(() => {
        console.log("Error while fetching data");
      });
  }

  generateUserNameIfNotPresent() {
    localStorage.setItem("testObject", "testing");
  }

  getRandomInt(max: number) {
    return Math.floor(Math.random() * max);
  }
}
</script>

<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
