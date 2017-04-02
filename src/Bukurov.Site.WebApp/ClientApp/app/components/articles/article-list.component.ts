import { Component, OnInit } from '@angular/core';
import { ArticleViewModel } from './article-view-models';
import { ArticleService } from './../../services/article.service';

@Component({
    selector: 'article-list',
    templateUrl: 'article-list.component.html'
})
export class ArticleListComponent implements OnInit {
    
    public articles: ArticleViewModel[];

    private _service: ArticleService;

    constructor(service: ArticleService) {
        this._service = service;
    }

    ngOnInit() {
        http.get('/api/articles').subscribe(result => {
            this.articles = result.json() as ArticleViewModel[];
        });
    }
}