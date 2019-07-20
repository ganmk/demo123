import React, { Component } from 'react';
import { connect } from 'dva';
import { Pagination } from 'antd';


export class UserMenuData extends Component {
    static displayName = UserMenuData.name;

    constructor(props) {
       
        super(props);
        this.state = { menus: [], loading: true, currentIndex: 1, total: 0, pageCount: 3 };

        var _data = {
            "current": this.state.currentIndex,
            "pageSize": this.state.pageCount
        }

        fetch('api/UserMenu/UserMenuList', {
            body: JSON.stringify(_data), // must match 'Content-Type' header
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            //credentials: 'same-origin', // include, same-origin, *omit
            headers: {
                'user-agent': 'Mozilla/4.0 MDN Example',
                'content-type': 'application/json'
            },
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, cors, *same-origin
            //redirect: 'follow', // manual, *follow, error
            referrer: 'no-referrer', // *client, no-referrer
        })
            .then(response => response.json())
            .then(data => {
                console.log(data);
                this.setState({
                    menus: data.data,
                    currentIndex: data.currentIndex,
                    pageCount: data.pageCount,
                    total: data.totalCount,
                    loading: false
                });

            });



    }

    loadData(payload = {}) {
        //const { dispatch } = this.props;
        //dispatch({
        //    type: 'api/UserMenu/UserMenuList',
        //    payload,
        //});
    }

    componentDidMount() {
       // this.loadData();
    }

    onPageChange=(page, pageSize)=>{
        //this.loadData({ currentIndex: page, pageCount:pageSize });
        alert(page)
        this.onShowSizeChange(page, pageSize);
    }

    onShowSizeChange=(page, pageSize)=>{
        //this.loadData({ currentIndex: page, pageCount: pageSize });

        //console.log(current, pageSize);
    
        //this.setState({ menus: [], loading: true });
       
        var _data = {
            "current": page,
            "pageSize": pageSize
        }
        fetch('api/UserMenu/UserMenuList', {
            body: JSON.stringify(_data), // must match 'Content-Type' header
            cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
            //credentials: 'same-origin', // include, same-origin, *omit
            headers: {
                'user-agent': 'Mozilla/4.0 MDN Example',
                'content-type': 'application/json'
            },
            method: 'POST', // *GET, POST, PUT, DELETE, etc.
            mode: 'cors', // no-cors, cors, *same-origin
            //redirect: 'follow', // manual, *follow, error
            referrer: 'no-referrer', // *client, no-referrer
        })
            .then(response => response.json())
            .then(data => {
                this.setState({
                    menus: data.data,
                    currentIndex: data.currentIndex,
                    pageCount: data.pageCount,
                    total: data.totalCount,
                    loading: false
                });
            }); 
    }


    static renderUserMenuTable(menus) {
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>um_title</th>
                        <th>um_url</th>
                        <th>parent_id</th>
                        <th>um_id</th>
                    </tr>
                </thead>
                <tbody>
                    {menus.map(menu =>
                        <tr key={menu.um_id}>
                            <td>{menu.um_title}</td>
                            <td>{menu.um_url}</td>
                            <td>{menu.parent_id}</td>
                            <td>{menu.um_id}</td>
                        </tr>
                    )}
                </tbody>
            </table>
            );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : UserMenuData.renderUserMenuTable(this.state.menus);
        return (
                 <div>
                    <h1>menu data</h1>
                {contents}
                <Pagination
                    onChange={this.onPageChange}
                    showSizeChanger
                    onShowSizeChange={this.onShowSizeChange}
                    defaultCurrent={this.state.currentIndex}
                    total={this.state.total}
                />
                 </div>
            );
    }


}