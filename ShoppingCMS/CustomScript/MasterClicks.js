function All_Product_CL() {
    alert("hello");
    $('#PageName').text("لیست همه ی محصولات");
    $('#LoadAll').load("https://localhost:44380/Product/Product_List");
}

function Add_Type_CL() {
    $('#PageName').text("دسته بندی اصلی محصولات");
    $('#LoadAll').load("https://localhost:44380/MS/Add_Type");
}

function Add_MainCat_CL() {
    $('#PageName').text("گروه اصلی محصولات");
    $('#LoadAll').load("https://localhost:44380/MS/Add_Type");
}

function Add_SubCat_CL() {
    $('#PageName').text("گروه محصولات");
    $('#LoadAll').load("https://localhost:44380/MS/Add_Type");
}