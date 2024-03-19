using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenerateIndexArray
	///
	///
	/// Generates a new vtkIdTypeArray containing zero-base indices.
	///
	/// vtkGenerateIndexArray operates in one of two distinct "modes".
	/// By default, it simply generates an index array containing
	/// monotonically-increasing integers in the range [0, N), where N
	/// is appropriately sized for the field type that will store the
	/// results.  This mode is useful for generating a unique ID field
	/// for datasets that have none.
	///
	/// The second "mode" uses an existing array from the input data
	/// object as a "reference".  Distinct values from the reference
	/// array are sorted in ascending order, and an integer index in
	/// the range [0, N) is assigned to each.  The resulting map is
	/// used to populate the output index array, mapping each value
	/// in the reference array to its corresponding index and storing
	/// the result in the output array.  This mode is especially
	/// useful when generating tensors, since it allows us to "map"
	/// from an array with arbitrary contents to an index that can
	/// be used as tensor coordinates.
	/// </summary>
	// Token: 0x0200067E RID: 1662
	public class vtkGenerateIndexArray : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E17 RID: 73239 RVA: 0x001905CF File Offset: 0x0018E7CF
		static vtkGenerateIndexArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenerateIndexArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenerateIndexArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011E18 RID: 73240 RVA: 0x001905F7 File Offset: 0x0018E7F7
		public vtkGenerateIndexArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011E19 RID: 73241
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateIndexArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E1A RID: 73242 RVA: 0x00190608 File Offset: 0x0018E808
		public new static vtkGenerateIndexArray New()
		{
			vtkGenerateIndexArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E1B RID: 73243 RVA: 0x0019065C File Offset: 0x0018E85C
		public vtkGenerateIndexArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenerateIndexArray.vtkGenerateIndexArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011E1C RID: 73244 RVA: 0x001906A0 File Offset: 0x0018E8A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011E1D RID: 73245
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateIndexArray_GetArrayName_01(HandleRef pThis);

		/// <summary>
		/// Control the output index array name.  Default: "index".
		/// </summary>
		// Token: 0x06011E1E RID: 73246 RVA: 0x001906AC File Offset: 0x0018E8AC
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenerateIndexArray.vtkGenerateIndexArray_GetArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011E1F RID: 73247
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateIndexArray_GetFieldType_02(HandleRef pThis);

		/// <summary>
		/// Control the location where the index array will be stored.
		/// </summary>
		// Token: 0x06011E20 RID: 73248 RVA: 0x001906E8 File Offset: 0x0018E8E8
		public virtual int GetFieldType()
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetFieldType_02(base.GetCppThis());
		}

		// Token: 0x06011E21 RID: 73249
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateIndexArray_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E22 RID: 73250 RVA: 0x00190708 File Offset: 0x0018E908
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06011E23 RID: 73251
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenerateIndexArray_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E24 RID: 73252 RVA: 0x00190728 File Offset: 0x0018E928
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06011E25 RID: 73253
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateIndexArray_GetPedigreeID_05(HandleRef pThis);

		/// <summary>
		/// Specifies whether the index array should be marked as
		/// pedigree ids.  Default: false.
		/// </summary>
		// Token: 0x06011E26 RID: 73254 RVA: 0x00190744 File Offset: 0x0018E944
		public virtual int GetPedigreeID()
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_GetPedigreeID_05(base.GetCppThis());
		}

		// Token: 0x06011E27 RID: 73255
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateIndexArray_GetReferenceArrayName_06(HandleRef pThis);

		/// <summary>
		/// Specifies an optional reference array for index-generation.
		/// </summary>
		// Token: 0x06011E28 RID: 73256 RVA: 0x00190764 File Offset: 0x0018E964
		public virtual string GetReferenceArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkGenerateIndexArray.vtkGenerateIndexArray_GetReferenceArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011E29 RID: 73257
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateIndexArray_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E2A RID: 73258 RVA: 0x001907A0 File Offset: 0x0018E9A0
		public override int IsA(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06011E2B RID: 73259
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenerateIndexArray_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E2C RID: 73260 RVA: 0x001907C0 File Offset: 0x0018E9C0
		public new static int IsTypeOf(string type)
		{
			return vtkGenerateIndexArray.vtkGenerateIndexArray_IsTypeOf_08(type);
		}

		// Token: 0x06011E2D RID: 73261
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateIndexArray_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E2E RID: 73262 RVA: 0x001907DC File Offset: 0x0018E9DC
		public new vtkGenerateIndexArray NewInstance()
		{
			vtkGenerateIndexArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011E2F RID: 73263
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenerateIndexArray_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E30 RID: 73264 RVA: 0x00190838 File Offset: 0x0018EA38
		public new static vtkGenerateIndexArray SafeDownCast(vtkObjectBase o)
		{
			vtkGenerateIndexArray vtkGenerateIndexArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenerateIndexArray.vtkGenerateIndexArray_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenerateIndexArray = (vtkGenerateIndexArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenerateIndexArray.Register(null);
				}
			}
			return vtkGenerateIndexArray;
		}

		// Token: 0x06011E31 RID: 73265
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateIndexArray_SetArrayName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Control the output index array name.  Default: "index".
		/// </summary>
		// Token: 0x06011E32 RID: 73266 RVA: 0x001908B7 File Offset: 0x0018EAB7
		public virtual void SetArrayName(string _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetArrayName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06011E33 RID: 73267
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateIndexArray_SetFieldType_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Control the location where the index array will be stored.
		/// </summary>
		// Token: 0x06011E34 RID: 73268 RVA: 0x001908C7 File Offset: 0x0018EAC7
		public virtual void SetFieldType(int _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetFieldType_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06011E35 RID: 73269
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateIndexArray_SetPedigreeID_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Specifies whether the index array should be marked as
		/// pedigree ids.  Default: false.
		/// </summary>
		// Token: 0x06011E36 RID: 73270 RVA: 0x001908D7 File Offset: 0x0018EAD7
		public virtual void SetPedigreeID(int _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetPedigreeID_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06011E37 RID: 73271
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGenerateIndexArray_SetReferenceArrayName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specifies an optional reference array for index-generation.
		/// </summary>
		// Token: 0x06011E38 RID: 73272 RVA: 0x001908E7 File Offset: 0x0018EAE7
		public virtual void SetReferenceArrayName(string _arg)
		{
			vtkGenerateIndexArray.vtkGenerateIndexArray_SetReferenceArrayName_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014A1 RID: 5281
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenerateIndexArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014A2 RID: 5282
		public new static readonly string MRClassNameKey = "class vtkGenerateIndexArray";

		/// <summary>
		/// Specifies whether the index array should be marked as
		/// pedigree ids.  Default: false.
		/// </summary>
		// Token: 0x0200067F RID: 1663
		public enum CELL_DATA_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x040014A4 RID: 5284
			CELL_DATA = 2,
			/// <summary>enum member</summary>
			// Token: 0x040014A5 RID: 5285
			EDGE_DATA = 4,
			/// <summary>enum member</summary>
			// Token: 0x040014A6 RID: 5286
			POINT_DATA = 1,
			/// <summary>enum member</summary>
			// Token: 0x040014A7 RID: 5287
			ROW_DATA = 0,
			/// <summary>enum member</summary>
			// Token: 0x040014A8 RID: 5288
			VERTEX_DATA = 3
		}
	}
}
