using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTreeDifferenceFilter
	/// </summary>
	/// <remarks>
	///    compare two trees
	///
	///
	/// vtkTreeDifferenceFilter compares two trees by analyzing a vtkDoubleArray.
	/// Each tree must have a copy of this array.  A user of this filter should
	/// call SetComparisonArrayName to specify the array that should be used as
	/// the basis of coparison.  This array can either be part of the trees'
	/// EdgeData or VertexData.
	///
	/// </remarks>
	// Token: 0x0200069D RID: 1693
	public class vtkTreeDifferenceFilter : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060121E1 RID: 74209 RVA: 0x00195F27 File Offset: 0x00194127
		static vtkTreeDifferenceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTreeDifferenceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTreeDifferenceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060121E2 RID: 74210 RVA: 0x00195F4F File Offset: 0x0019414F
		public vtkTreeDifferenceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060121E3 RID: 74211
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121E4 RID: 74212 RVA: 0x00195F60 File Offset: 0x00194160
		public new static vtkTreeDifferenceFilter New()
		{
			vtkTreeDifferenceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121E5 RID: 74213 RVA: 0x00195FB4 File Offset: 0x001941B4
		public vtkTreeDifferenceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060121E6 RID: 74214 RVA: 0x00195FF8 File Offset: 0x001941F8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060121E7 RID: 74215
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTreeDifferenceFilter_GetComparisonArrayIsVertexData_01(HandleRef pThis);

		/// <summary>
		/// Specify whether the comparison array is within the trees' vertex data or
		/// not.  By default, we assume that the array to compare is within the trees'
		/// EdgeData().
		/// </summary>
		// Token: 0x060121E8 RID: 74216 RVA: 0x00196004 File Offset: 0x00194204
		public virtual bool GetComparisonArrayIsVertexData()
		{
			return vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetComparisonArrayIsVertexData_01(base.GetCppThis()) != 0;
		}

		// Token: 0x060121E9 RID: 74217
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_GetComparisonArrayName_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the array that we're comparing between the two trees.
		/// The named array must be a vtkDoubleArray.
		/// </summary>
		// Token: 0x060121EA RID: 74218 RVA: 0x0019602C File Offset: 0x0019422C
		public virtual string GetComparisonArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetComparisonArrayName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060121EB RID: 74219
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_GetIdArrayName_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of the identifier array in the trees' VertexData.
		/// This array is used to find corresponding vertices in the two trees.
		/// If this array name is not set, then we assume that the vertices in
		/// the two trees to compare have corresponding vtkIdTypes.
		/// Otherwise, the named array must be a vtkStringArray.
		/// The identifier array does not necessarily have to specify a name for
		/// each vertex in the tree.  If some vertices are unnamed, then this
		/// filter will assign correspondence between ancestors of named vertices.
		/// </summary>
		// Token: 0x060121EC RID: 74220 RVA: 0x00196068 File Offset: 0x00194268
		public virtual string GetIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetIdArrayName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060121ED RID: 74221
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121EE RID: 74222 RVA: 0x001960A4 File Offset: 0x001942A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060121EF RID: 74223
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121F0 RID: 74224 RVA: 0x001960C4 File Offset: 0x001942C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060121F1 RID: 74225
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_GetOutputArrayName_06(HandleRef pThis);

		/// <summary>
		/// Set/Get the name of a new vtkDoubleArray that will contain the results of
		/// the comparison between the two trees.  This new array will be added to
		/// the input tree's VertexData or EdgeData, based on the value of
		/// ComparisonArrayIsVertexData.  If this method is not called, the new
		/// vtkDoubleArray will be named "difference" by default.
		/// </summary>
		// Token: 0x060121F2 RID: 74226 RVA: 0x001960E0 File Offset: 0x001942E0
		public virtual string GetOutputArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_GetOutputArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060121F3 RID: 74227
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeDifferenceFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121F4 RID: 74228 RVA: 0x0019611C File Offset: 0x0019431C
		public override int IsA(string type)
		{
			return vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060121F5 RID: 74229
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTreeDifferenceFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121F6 RID: 74230 RVA: 0x0019613C File Offset: 0x0019433C
		public new static int IsTypeOf(string type)
		{
			return vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_IsTypeOf_08(type);
		}

		// Token: 0x060121F7 RID: 74231
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121F8 RID: 74232 RVA: 0x00196158 File Offset: 0x00194358
		public new vtkTreeDifferenceFilter NewInstance()
		{
			vtkTreeDifferenceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060121F9 RID: 74233
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTreeDifferenceFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060121FA RID: 74234 RVA: 0x001961B4 File Offset: 0x001943B4
		public new static vtkTreeDifferenceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkTreeDifferenceFilter vtkTreeDifferenceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTreeDifferenceFilter = (vtkTreeDifferenceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTreeDifferenceFilter.Register(null);
				}
			}
			return vtkTreeDifferenceFilter;
		}

		// Token: 0x060121FB RID: 74235
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeDifferenceFilter_SetComparisonArrayIsVertexData_12(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify whether the comparison array is within the trees' vertex data or
		/// not.  By default, we assume that the array to compare is within the trees'
		/// EdgeData().
		/// </summary>
		// Token: 0x060121FC RID: 74236 RVA: 0x00196233 File Offset: 0x00194433
		public virtual void SetComparisonArrayIsVertexData(bool _arg)
		{
			vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_SetComparisonArrayIsVertexData_12(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060121FD RID: 74237
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeDifferenceFilter_SetComparisonArrayName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the array that we're comparing between the two trees.
		/// The named array must be a vtkDoubleArray.
		/// </summary>
		// Token: 0x060121FE RID: 74238 RVA: 0x0019624B File Offset: 0x0019444B
		public virtual void SetComparisonArrayName(string _arg)
		{
			vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_SetComparisonArrayName_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060121FF RID: 74239
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeDifferenceFilter_SetIdArrayName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of the identifier array in the trees' VertexData.
		/// This array is used to find corresponding vertices in the two trees.
		/// If this array name is not set, then we assume that the vertices in
		/// the two trees to compare have corresponding vtkIdTypes.
		/// Otherwise, the named array must be a vtkStringArray.
		/// The identifier array does not necessarily have to specify a name for
		/// each vertex in the tree.  If some vertices are unnamed, then this
		/// filter will assign correspondence between ancestors of named vertices.
		/// </summary>
		// Token: 0x06012200 RID: 74240 RVA: 0x0019625B File Offset: 0x0019445B
		public virtual void SetIdArrayName(string _arg)
		{
			vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_SetIdArrayName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06012201 RID: 74241
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTreeDifferenceFilter_SetOutputArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/Get the name of a new vtkDoubleArray that will contain the results of
		/// the comparison between the two trees.  This new array will be added to
		/// the input tree's VertexData or EdgeData, based on the value of
		/// ComparisonArrayIsVertexData.  If this method is not called, the new
		/// vtkDoubleArray will be named "difference" by default.
		/// </summary>
		// Token: 0x06012202 RID: 74242 RVA: 0x0019626B File Offset: 0x0019446B
		public virtual void SetOutputArrayName(string _arg)
		{
			vtkTreeDifferenceFilter.vtkTreeDifferenceFilter_SetOutputArrayName_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E8 RID: 5352
		public new const string MRFullTypeName = "Kitware.VTK.vtkTreeDifferenceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014E9 RID: 5353
		public new static readonly string MRClassNameKey = "class vtkTreeDifferenceFilter";
	}
}
