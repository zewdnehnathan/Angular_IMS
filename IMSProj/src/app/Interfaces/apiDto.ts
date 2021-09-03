import { Purchase } from "./purchase";

export interface APIDto{

      Data : Purchase[][];
      IsSuccess : boolean;
      Message : string;
}