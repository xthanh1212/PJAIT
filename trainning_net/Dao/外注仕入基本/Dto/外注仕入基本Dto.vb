<Serializable>
Public Class 外注仕入基本Dto
    Public Property 仕入番号 As String
    Public Property 発注番号 As String
    Public Property 連番 As Decimal
    Public Property 受注番号 As String
    Public Property 仕入日 As Date
    Public Property 発注日 As Date
    Public Property 発注先 As String
    Public Property 発注先名 As String
    Public Property 発注担当 As String
    Public Property 発注担当名 As String
    Public Property 取引区分 As String
    Public Property その他経費 As Decimal?
    Public Property その他経費課税区分 As String
    Public Property その他経費税率 As String
    Public Property 値引 As Decimal?
    Public Property 値引課税区分 As String

    Public Property 値引税率 As String
    Public Property 金額 As Decimal
    Public Property 合計 As Decimal
    Public Property 支払予定日 As Date
    Public Property 備考1 As String
    Public Property 備考2 As String
    Public Property 備考3 As String

    Public Property 削除フラグ As Boolean?
    Public Property 登録日 As Date?
    Public Property 登録者 As String
    Public Property 更新日 As Date?
    Public Property 更新者 As String

End Class
