var editModal =Vue.component("edit-modal", {

});

var vm = new Vue({
    el: "#schoolApp",
    data: {
        schools: []
    },
    created() {
        this.getSchools();
    },
    methods: {
        deleteSchool: function (school,event) {
            if (confirm("Sure you want to delete this row?")) {
                var vue = this;
                fetch("https://localhost:5000/api/v1/schools"+school.id,
                    {
                        method: "DELETE",
                        contentType: "application/json",
                        headers: {
                            'Content-Type': 'application/json'
                        }
                        }
                ).then(response => response.json())
                    .then(function (response) {
                        alert("School deleted");
                    });
             }
        },
        getSchools: function () {
            var vue = this;
            fetch("https://localhost:5000/api/v1/schools",
                {
                    method: "GET",
                    contentType: "application/json",
                    headers: {
                        'Content-Type': 'application/json'
                    }
                    }
            ).then(response => response.json())
                .then(function (response) {
                    vue.schools = response;
                });
             
        }
    }
});