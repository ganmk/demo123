import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { Tree } from 'antd';
import ContentDiv  from './Content';
import { Layout } from 'antd';

const { TreeNode } = Tree;
const { Header, Footer, Sider, Content } = Layout;

export class MenuTree extends Component {

    static displayName = MenuTree.name;
    state = {
        treeData: [
            //{ title: 'Expand to load', key: '0' },
            //{ title: 'Expand to load', key: '1' },
            //{ title: 'Tree Node', key: '2', isLeaf: true },
        ],
    };

    constructor(props) {
        super(props);

        fetch('api/UserMenu/MenuTree')
            .then(response => response.json())
            .then(data => {
                this.setState({ treeData: data});
            })

    }

    onClick = (e) => {
        alert(e.target.textContent);

    };

     onLoadData = treeNode =>
         new Promise(resolve => {
             resolve();
             return;
            //if (treeNode.props.children) {
            //    resolve();
            //    return;
            //}
            // setTimeout(() => {
            //     alert(treeNode.props.eventKey)
            //    treeNode.props.dataRef.children = [
            //        { title: 'Child Node', key: `${treeNode.props.eventKey}-0` },
            //        { title: 'Child Node', key: `${treeNode.props.eventKey}-1` },
            //    ];
            //    this.setState({
            //        treeData: [...this.state.treeData],
            //    });
            //    resolve();
            //}, 1000);
      });

       renderTreeNodes = data =>
        data.map(item => {
            if (item.children) {
                return (
                    <TreeNode title={item.title} key={item.key} dataRef={item}>
                        {this.renderTreeNodes(item.children)}
                    </TreeNode>
                );
            }
            return <TreeNode {...item} dataRef={item} />;
        });


    onLoadContent = () => { };

    render() {
        var content = this.onLoadContent;
        return (
            <div>
                <Layout>
                    <Sider>
                        <Tree onClick={this.onClick} loadData={this.onLoadData}>{this.renderTreeNodes(this.state.treeData)}</Tree>;
                     </Sider>
                    <Content>
                        <ContentDiv/>
                    </Content>
                </Layout>
            </div>
        );
    };

}