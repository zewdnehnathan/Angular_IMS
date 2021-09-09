import { Purchase } from "./purchase";

export interface APIDto{

      data : Purchase[];
      isSuccess : boolean;
      message : string;
}
