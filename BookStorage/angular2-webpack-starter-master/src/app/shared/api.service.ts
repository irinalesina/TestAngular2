import {Http, RequestOptions, Headers} from '@angular/http';
import {Response} from "@angular/http";
import {Observable} from "rxjs";
import {Injectable} from "@angular/core";

@Injectable()
export class ApiService {
    private apiRoutes = {
        dev: "http://localhost:5000/api/",
        master: "/api/"
    };
    private baseApiRoute: string = this.apiRoutes.dev;

    constructor(private http: Http) {
    }

    public getAll(url: string): Observable<Response> {
        return this.http.get(this.baseApiRoute + url);
    }

    public getById(url: string, id: number): Observable<Response> {
        return this.http.get(this.baseApiRoute + url + '/' + id);
    }

    public delete(url: string, id: number): Observable<Response> {
        return this.http.delete(this.baseApiRoute + url + '/' + id);
    }

    public add(url: string, data): Observable<Response> {
        let body = JSON.stringify(data);
        console.log("Body: ", body);
        return this.http.post(this.baseApiRoute + url, body, this.getOptions());
    }

    private getOptions(): RequestOptions {
        let opts: RequestOptions = new RequestOptions();
        opts.headers = new Headers();
        opts.headers.append("Content-Type", "application/json; charset=utf-8");
        return opts;
    }
};
