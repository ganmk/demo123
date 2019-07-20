import React from 'react';
import styles from './index.css';
import { Pagination } from 'antd';

export class PageTool extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            agriculturalList: [],
            currentData: [],
            total: 20,
            pageSize: 10,
            pageNumber: parseInt(window.location.hash.slice(1), 0) || 1, //获取当前页面的hash值，转换为number类型
        };
        // 在react中点击事件里面 setState 时会使this重新定义，所以在点击的函数里面使用this.setState()时会报错this.setState not a function，因此需要提前给点击事件的函数绑定this
        this.onPageChange = this.onPageChange.bind(this);
    }

    loadData(payload = {}) {
        this.props.dispatch({
            type: '',
            payload,
        });
    }

    componentDidMount() {
        this.loadData();
    }

    onPageChange(page, pageSize) {
        this.loadData({ pageNumber: page, pageSize });
    }

    render() {

        //分页
        const agriculturalListData = this.state.currentData;

        return (
            <div className={styles.PaginationStyle}>
                <Pagination
                    showQuickJumper
                    hideOnSinglePage={false}
                    defaultCurrent={this.state.pageNumber}
                    current={this.state.pageNumber}
                    total={this.state.total}
                    pageSize={this.state.pageSize}
                    onChange={this.onPageChange}
                    showTotal={e => {
                        return 'Total' + e + 'items';
                    }}
                />
            </div>
        );
    }
}

