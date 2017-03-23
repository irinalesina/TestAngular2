import {Genre} from "../genres/genre.model";


export class Book{
    id: number;
    name: string;
    text: string;
    year: number;
    genres: Genre[];
}