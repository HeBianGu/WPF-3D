using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSTLReader
	/// </summary>
	/// <remarks>
	///    read ASCII or binary stereo lithography files
	///
	/// vtkSTLReader is a source object that reads ASCII or binary stereo
	/// lithography files (.stl files). The FileName must be specified to
	/// vtkSTLReader. The object automatically detects whether the file is
	/// ASCII or binary.
	///
	/// .stl files are quite inefficient since they duplicate vertex
	/// definitions. By setting the Merging boolean you can control whether the
	/// point data is merged after reading. Merging is performed by default,
	/// however, merging requires a large amount of temporary storage since a
	/// 3D hash table must be constructed.
	///
	/// @warning
	/// Binary files written on one system may not be readable on other systems.
	/// vtkSTLWriter uses VAX or PC byte ordering and swaps bytes on other systems.
	/// </remarks>
	// Token: 0x02000212 RID: 530
	public class vtkSTLReader : vtkAbstractPolyDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006502 RID: 25858 RVA: 0x000913D7 File Offset: 0x0008F5D7
		static vtkSTLReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSTLReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSTLReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006503 RID: 25859 RVA: 0x000913FF File Offset: 0x0008F5FF
		public vtkSTLReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006504 RID: 25860
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with merging set to true.
		/// </summary>
		// Token: 0x06006505 RID: 25861 RVA: 0x00091410 File Offset: 0x0008F610
		public new static vtkSTLReader New()
		{
			vtkSTLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with merging set to true.
		/// </summary>
		// Token: 0x06006506 RID: 25862 RVA: 0x00091464 File Offset: 0x0008F664
		public vtkSTLReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSTLReader.vtkSTLReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006507 RID: 25863 RVA: 0x000914A8 File Offset: 0x0008F6A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006508 RID: 25864
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_GetBinaryHeader_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get binary file header string.
		/// If ASCII STL file is read then BinaryHeader is not set,
		/// and the header can be retrieved using.GetHeader() instead.
		/// \sa GetHeader()
		/// </summary>
		// Token: 0x06006509 RID: 25865 RVA: 0x000914B4 File Offset: 0x0008F6B4
		public virtual vtkUnsignedCharArray GetBinaryHeader()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_GetBinaryHeader_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x0600650A RID: 25866
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_GetHeader_02(HandleRef pThis);

		/// <summary>
		/// Get header string.
		/// If an ASCII STL file contains multiple solids then
		/// headers are separated by newline character.
		/// If a binary STL file is read, the first zero-terminated
		/// string is stored in this header, the full header is available
		/// by using GetBinaryHeader().
		/// \sa GetBinaryHeader()
		/// </summary>
		// Token: 0x0600650B RID: 25867 RVA: 0x00091524 File Offset: 0x0008F724
		public virtual string GetHeader()
		{
			string s = Marshal.PtrToStringAnsi(vtkSTLReader.vtkSTLReader_GetHeader_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600650C RID: 25868
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_GetLocator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600650D RID: 25869 RVA: 0x00091560 File Offset: 0x0008F760
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_GetLocator_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIncrementalPointLocator = (vtkIncrementalPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIncrementalPointLocator.Register(null);
				}
			}
			return vtkIncrementalPointLocator;
		}

		// Token: 0x0600650E RID: 25870
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkSTLReader_GetMTime_04(HandleRef pThis);

		/// <summary>
		/// Overload standard modified time function. If locator is modified,
		/// then this object is modified as well.
		/// </summary>
		// Token: 0x0600650F RID: 25871 RVA: 0x000915D0 File Offset: 0x0008F7D0
		public override ulong GetMTime()
		{
			return vtkSTLReader.vtkSTLReader_GetMTime_04(base.GetCppThis());
		}

		// Token: 0x06006510 RID: 25872
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLReader_GetMerging_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points/triangles.
		/// </summary>
		// Token: 0x06006511 RID: 25873 RVA: 0x000915F0 File Offset: 0x0008F7F0
		public virtual int GetMerging()
		{
			return vtkSTLReader.vtkSTLReader_GetMerging_05(base.GetCppThis());
		}

		// Token: 0x06006512 RID: 25874
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSTLReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006513 RID: 25875 RVA: 0x00091610 File Offset: 0x0008F810
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSTLReader.vtkSTLReader_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06006514 RID: 25876
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSTLReader_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006515 RID: 25877 RVA: 0x00091630 File Offset: 0x0008F830
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSTLReader.vtkSTLReader_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06006516 RID: 25878
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLReader_GetScalarTags_08(HandleRef pThis);

		/// <summary>
		/// Turn on/off tagging of solids with scalars.
		/// </summary>
		// Token: 0x06006517 RID: 25879 RVA: 0x0009164C File Offset: 0x0008F84C
		public virtual int GetScalarTags()
		{
			return vtkSTLReader.vtkSTLReader_GetScalarTags_08(base.GetCppThis());
		}

		// Token: 0x06006518 RID: 25880
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLReader_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006519 RID: 25881 RVA: 0x0009166C File Offset: 0x0008F86C
		public override int IsA(string type)
		{
			return vtkSTLReader.vtkSTLReader_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600651A RID: 25882
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSTLReader_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600651B RID: 25883 RVA: 0x0009168C File Offset: 0x0008F88C
		public new static int IsTypeOf(string type)
		{
			return vtkSTLReader.vtkSTLReader_IsTypeOf_10(type);
		}

		// Token: 0x0600651C RID: 25884
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_MergingOff_11(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points/triangles.
		/// </summary>
		// Token: 0x0600651D RID: 25885 RVA: 0x000916A6 File Offset: 0x0008F8A6
		public virtual void MergingOff()
		{
			vtkSTLReader.vtkSTLReader_MergingOff_11(base.GetCppThis());
		}

		// Token: 0x0600651E RID: 25886
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_MergingOn_12(HandleRef pThis);

		/// <summary>
		/// Turn on/off merging of points/triangles.
		/// </summary>
		// Token: 0x0600651F RID: 25887 RVA: 0x000916B5 File Offset: 0x0008F8B5
		public virtual void MergingOn()
		{
			vtkSTLReader.vtkSTLReader_MergingOn_12(base.GetCppThis());
		}

		// Token: 0x06006520 RID: 25888
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006521 RID: 25889 RVA: 0x000916C4 File Offset: 0x0008F8C4
		public new vtkSTLReader NewInstance()
		{
			vtkSTLReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006522 RID: 25890
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSTLReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006523 RID: 25891 RVA: 0x00091720 File Offset: 0x0008F920
		public new static vtkSTLReader SafeDownCast(vtkObjectBase o)
		{
			vtkSTLReader vtkSTLReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSTLReader.vtkSTLReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSTLReader = (vtkSTLReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSTLReader.Register(null);
				}
			}
			return vtkSTLReader;
		}

		// Token: 0x06006524 RID: 25892
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_ScalarTagsOff_16(HandleRef pThis);

		/// <summary>
		/// Turn on/off tagging of solids with scalars.
		/// </summary>
		// Token: 0x06006525 RID: 25893 RVA: 0x0009179F File Offset: 0x0008F99F
		public virtual void ScalarTagsOff()
		{
			vtkSTLReader.vtkSTLReader_ScalarTagsOff_16(base.GetCppThis());
		}

		// Token: 0x06006526 RID: 25894
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_ScalarTagsOn_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off tagging of solids with scalars.
		/// </summary>
		// Token: 0x06006527 RID: 25895 RVA: 0x000917AE File Offset: 0x0008F9AE
		public virtual void ScalarTagsOn()
		{
			vtkSTLReader.vtkSTLReader_ScalarTagsOn_17(base.GetCppThis());
		}

		// Token: 0x06006528 RID: 25896
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_SetLocator_18(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a spatial locator for merging points. By
		/// default an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x06006529 RID: 25897 RVA: 0x000917C0 File Offset: 0x0008F9C0
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkSTLReader.vtkSTLReader_SetLocator_18(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600652A RID: 25898
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_SetMerging_19(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off merging of points/triangles.
		/// </summary>
		// Token: 0x0600652B RID: 25899 RVA: 0x000917EF File Offset: 0x0008F9EF
		public virtual void SetMerging(int _arg)
		{
			vtkSTLReader.vtkSTLReader_SetMerging_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600652C RID: 25900
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSTLReader_SetScalarTags_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off tagging of solids with scalars.
		/// </summary>
		// Token: 0x0600652D RID: 25901 RVA: 0x000917FF File Offset: 0x0008F9FF
		public virtual void SetScalarTags(int _arg)
		{
			vtkSTLReader.vtkSTLReader_SetScalarTags_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000907 RID: 2311
		public new const string MRFullTypeName = "Kitware.VTK.vtkSTLReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000908 RID: 2312
		public new static readonly string MRClassNameKey = "class vtkSTLReader";
	}
}
