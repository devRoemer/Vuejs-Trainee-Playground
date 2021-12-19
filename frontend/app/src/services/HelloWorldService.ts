import Axios from "@/plugins/Axios";

export class HelloWorldService {
  public async greet(userName: string): Promise<string> {
    if (!userName) {
      throw Error("Username may not be empty");
    }

    const result = await Axios.api.get<string>(`Greet?userName=${userName}`);
    return result.data;
  }
}
