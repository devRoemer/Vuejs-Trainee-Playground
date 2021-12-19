import axios, { AxiosInstance } from "axios";

class Axios {
  public api: AxiosInstance = null;

  public constructor() {
    this.api = this.createApi();
  }

  private createApi(): AxiosInstance {
    const client = axios.create();
    client.defaults.baseURL = "http://localhost:5000/api/";
    return client;
  }
}

export default new Axios();
