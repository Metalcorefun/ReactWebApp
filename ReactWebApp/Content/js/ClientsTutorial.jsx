class ThingList extends React.Component {
    constructor(props) {
        super(props);
        this.state = { things: [] };
    }
    loadData() {
        var xhr = new XMLHttpRequest();
        xhr.open("get", this.props.getUrl, true);
        xhr.onload = function() {
            var data = JSON.parse(xhr.responseText);
            this.setState({ things: data });
        }.bind(this);
        xhr.send();
    }
    componentDidMount() {
        this.loadData();
    }
    render() {
        return (
            <div>
                <h2>Список всяких разных штук</h2>
            <div>
                {
                    this.state.things.map(function (thing) {
                        return <Thing thing={thing} />
                    })
                }
            </div>
        </div>
        );
    }
}

class Thing extends React.Component {
    constructor(props) {
        super(props);
        this.state = { data: props.thing };
    }
    render() {
        return (
            <div>
                <h3>{this.state.data.Title}</h3>
                <span>{this.state.data.Count}</span>
            </div>
        );
    }
}

ReactDOM.render(
    <ThingList getUrl="/home/getthings" />,
    document.getElementById("place")
);

