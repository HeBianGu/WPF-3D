using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCollapseVerticesByArray
	/// </summary>
	/// <remarks>
	///    Collapse the graph given a vertex array
	///
	///
	/// vtkCollapseVerticesByArray is a class which collapses the graph using
	/// a vertex array as the key. So if the graph has vertices sharing common
	/// traits then this class combines all these vertices into one. This class
	/// does not perform aggregation on vertex data but allow to do so for edge data.
	/// Users can choose one or more edge data arrays for aggregation using
	/// AddAggregateEdgeArray function.
	///
	///
	/// </remarks>
	// Token: 0x02000675 RID: 1653
	public class vtkCollapseVerticesByArray : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011CF5 RID: 72949 RVA: 0x0018EC7F File Offset: 0x0018CE7F
		static vtkCollapseVerticesByArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCollapseVerticesByArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseVerticesByArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011CF6 RID: 72950 RVA: 0x0018ECA7 File Offset: 0x0018CEA7
		public vtkCollapseVerticesByArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011CF7 RID: 72951
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CF8 RID: 72952 RVA: 0x0018ECB8 File Offset: 0x0018CEB8
		public new static vtkCollapseVerticesByArray New()
		{
			vtkCollapseVerticesByArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011CF9 RID: 72953 RVA: 0x0018ED0C File Offset: 0x0018CF0C
		public vtkCollapseVerticesByArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011CFA RID: 72954 RVA: 0x0018ED50 File Offset: 0x0018CF50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011CFB RID: 72955
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arrName);

		/// <summary>
		/// Add arrays on which aggregation of data is allowed.
		/// Default if replaced by the last value.
		/// </summary>
		// Token: 0x06011CFC RID: 72956 RVA: 0x0018ED5B File Offset: 0x0018CF5B
		public void AddAggregateEdgeArray(string arrName)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(base.GetCppThis(), arrName);
		}

		// Token: 0x06011CFD RID: 72957
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(HandleRef pThis);

		/// <summary>
		/// Boolean to allow self loops during collapse.
		/// </summary>
		// Token: 0x06011CFE RID: 72958 RVA: 0x0018ED6B File Offset: 0x0018CF6B
		public virtual void AllowSelfLoopsOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(base.GetCppThis());
		}

		// Token: 0x06011CFF RID: 72959
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(HandleRef pThis);

		/// <summary>
		/// Boolean to allow self loops during collapse.
		/// </summary>
		// Token: 0x06011D00 RID: 72960 RVA: 0x0018ED7A File Offset: 0x0018CF7A
		public virtual void AllowSelfLoopsOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(base.GetCppThis());
		}

		// Token: 0x06011D01 RID: 72961
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(HandleRef pThis);

		/// <summary>
		/// Clear the list of arrays on which aggregation was set to allow.
		/// </summary>
		// Token: 0x06011D02 RID: 72962 RVA: 0x0018ED89 File Offset: 0x0018CF89
		public void ClearAggregateEdgeArray()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(base.GetCppThis());
		}

		// Token: 0x06011D03 RID: 72963
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(HandleRef pThis);

		/// <summary>
		/// Set if count should be made of how many edges collapsed.
		/// </summary>
		// Token: 0x06011D04 RID: 72964 RVA: 0x0018ED98 File Offset: 0x0018CF98
		public virtual void CountEdgesCollapsedOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(base.GetCppThis());
		}

		// Token: 0x06011D05 RID: 72965
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(HandleRef pThis);

		/// <summary>
		/// Set if count should be made of how many edges collapsed.
		/// </summary>
		// Token: 0x06011D06 RID: 72966 RVA: 0x0018EDA7 File Offset: 0x0018CFA7
		public virtual void CountEdgesCollapsedOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(base.GetCppThis());
		}

		// Token: 0x06011D07 RID: 72967
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(HandleRef pThis);

		/// <summary>
		/// Get/Set if count should be made of how many vertices collapsed.
		/// </summary>
		// Token: 0x06011D08 RID: 72968 RVA: 0x0018EDB6 File Offset: 0x0018CFB6
		public virtual void CountVerticesCollapsedOff()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(base.GetCppThis());
		}

		// Token: 0x06011D09 RID: 72969
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(HandleRef pThis);

		/// <summary>
		/// Get/Set if count should be made of how many vertices collapsed.
		/// </summary>
		// Token: 0x06011D0A RID: 72970 RVA: 0x0018EDC5 File Offset: 0x0018CFC5
		public virtual void CountVerticesCollapsedOn()
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(base.GetCppThis());
		}

		// Token: 0x06011D0B RID: 72971
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCollapseVerticesByArray_GetAllowSelfLoops_09(HandleRef pThis);

		/// <summary>
		/// Boolean to allow self loops during collapse.
		/// </summary>
		// Token: 0x06011D0C RID: 72972 RVA: 0x0018EDD4 File Offset: 0x0018CFD4
		public virtual bool GetAllowSelfLoops()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetAllowSelfLoops_09(base.GetCppThis()) != 0;
		}

		// Token: 0x06011D0D RID: 72973
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(HandleRef pThis);

		/// <summary>
		/// Set if count should be made of how many edges collapsed.
		/// </summary>
		// Token: 0x06011D0E RID: 72974 RVA: 0x0018EDFC File Offset: 0x0018CFFC
		public virtual bool GetCountEdgesCollapsed()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(base.GetCppThis()) != 0;
		}

		// Token: 0x06011D0F RID: 72975
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(HandleRef pThis);

		/// <summary>
		/// Get/Set if count should be made of how many vertices collapsed.
		/// </summary>
		// Token: 0x06011D10 RID: 72976 RVA: 0x0018EE24 File Offset: 0x0018D024
		public virtual bool GetCountVerticesCollapsed()
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(base.GetCppThis()) != 0;
		}

		// Token: 0x06011D11 RID: 72977
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(HandleRef pThis);

		/// <summary>
		/// Name of the array where the count of how many edges collapsed will
		/// be stored.By default the name of array is "EdgesCollapsedCountArray".
		/// </summary>
		// Token: 0x06011D12 RID: 72978 RVA: 0x0018EE4C File Offset: 0x0018D04C
		public virtual string GetEdgesCollapsedArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011D13 RID: 72979
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D14 RID: 72980 RVA: 0x0018EE88 File Offset: 0x0018D088
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06011D15 RID: 72981
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D16 RID: 72982 RVA: 0x0018EEA8 File Offset: 0x0018D0A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06011D17 RID: 72983
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetVertexArray_15(HandleRef pThis);

		/// <summary>
		/// Set the array using which perform the collapse.
		/// </summary>
		// Token: 0x06011D18 RID: 72984 RVA: 0x0018EEC4 File Offset: 0x0018D0C4
		public virtual string GetVertexArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetVertexArray_15(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011D19 RID: 72985
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_GetVerticesCollapsedArray_16(HandleRef pThis);

		/// <summary>
		/// Name of the array where the count of how many vertices collapsed will
		/// be stored. By default name of the array is "VerticesCollapsedCountArray".
		/// </summary>
		// Token: 0x06011D1A RID: 72986 RVA: 0x0018EF00 File Offset: 0x0018D100
		public virtual string GetVerticesCollapsedArray()
		{
			string s = Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_GetVerticesCollapsedArray_16(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011D1B RID: 72987
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollapseVerticesByArray_IsA_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D1C RID: 72988 RVA: 0x0018EF3C File Offset: 0x0018D13C
		public override int IsA(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_IsA_17(base.GetCppThis(), type);
		}

		// Token: 0x06011D1D RID: 72989
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCollapseVerticesByArray_IsTypeOf_18([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D1E RID: 72990 RVA: 0x0018EF5C File Offset: 0x0018D15C
		public new static int IsTypeOf(string type)
		{
			return vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_IsTypeOf_18(type);
		}

		// Token: 0x06011D1F RID: 72991
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D20 RID: 72992 RVA: 0x0018EF78 File Offset: 0x0018D178
		public new vtkCollapseVerticesByArray NewInstance()
		{
			vtkCollapseVerticesByArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_NewInstance_20(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011D21 RID: 72993
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCollapseVerticesByArray_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D22 RID: 72994 RVA: 0x0018EFD4 File Offset: 0x0018D1D4
		public new static vtkCollapseVerticesByArray SafeDownCast(vtkObjectBase o)
		{
			vtkCollapseVerticesByArray vtkCollapseVerticesByArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollapseVerticesByArray = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollapseVerticesByArray.Register(null);
				}
			}
			return vtkCollapseVerticesByArray;
		}

		// Token: 0x06011D23 RID: 72995
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetAllowSelfLoops_22(HandleRef pThis, byte _arg);

		/// <summary>
		/// Boolean to allow self loops during collapse.
		/// </summary>
		// Token: 0x06011D24 RID: 72996 RVA: 0x0018F053 File Offset: 0x0018D253
		public virtual void SetAllowSelfLoops(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetAllowSelfLoops_22(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011D25 RID: 72997
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetCountEdgesCollapsed_23(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set if count should be made of how many edges collapsed.
		/// </summary>
		// Token: 0x06011D26 RID: 72998 RVA: 0x0018F06B File Offset: 0x0018D26B
		public virtual void SetCountEdgesCollapsed(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetCountEdgesCollapsed_23(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011D27 RID: 72999
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetCountVerticesCollapsed_24(HandleRef pThis, byte _arg);

		/// <summary>
		/// Get/Set if count should be made of how many vertices collapsed.
		/// </summary>
		// Token: 0x06011D28 RID: 73000 RVA: 0x0018F083 File Offset: 0x0018D283
		public virtual void SetCountVerticesCollapsed(bool _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetCountVerticesCollapsed_24(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06011D29 RID: 73001
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetEdgesCollapsedArray_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Name of the array where the count of how many edges collapsed will
		/// be stored.By default the name of array is "EdgesCollapsedCountArray".
		/// </summary>
		// Token: 0x06011D2A RID: 73002 RVA: 0x0018F09B File Offset: 0x0018D29B
		public virtual void SetEdgesCollapsedArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetEdgesCollapsedArray_25(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D2B RID: 73003
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetVertexArray_26(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the array using which perform the collapse.
		/// </summary>
		// Token: 0x06011D2C RID: 73004 RVA: 0x0018F0AB File Offset: 0x0018D2AB
		public virtual void SetVertexArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetVertexArray_26(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D2D RID: 73005
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCollapseVerticesByArray_SetVerticesCollapsedArray_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Name of the array where the count of how many vertices collapsed will
		/// be stored. By default name of the array is "VerticesCollapsedCountArray".
		/// </summary>
		// Token: 0x06011D2E RID: 73006 RVA: 0x0018F0BB File Offset: 0x0018D2BB
		public virtual void SetVerticesCollapsedArray(string _arg)
		{
			vtkCollapseVerticesByArray.vtkCollapseVerticesByArray_SetVerticesCollapsedArray_27(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148B RID: 5259
		public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseVerticesByArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400148C RID: 5260
		public new static readonly string MRClassNameKey = "class vtkCollapseVerticesByArray";
	}
}
