var items = new vis.DataSet({type: { start: 'ISODate', end: 'ISODate' }});
var groups = new vis.DataSet
([
{id: 'bar',
content: 'График',subgroupStack: { sg_1: true},
subgroupVisibility: { sg_1: true}}
]);
items.add(
[{id: 1,
content: 'АДПМ на базе Камаз',
start: '2020-11-29T08:00:00' ,
end: '2020-12-11T08:00:00',
group: 'bar',
subgroup: 'sg_1',
subgroupOrder: 0 },
]);
items.add(
[{id: 2,
content: 'Автокран',
start: '2020-12-02T09:00:00' ,
end: '2020-12-02T17:30:00',
group: 'bar',
subgroup: 'sg_1',
subgroupOrder: 0 },
]);
var container = document.getElementById('visualization'); 
var options = { 
start:'2020-11-28',
end:'2020-12-11' ,
};
var timeline = new vis.Timeline(container, items, groups, options); 