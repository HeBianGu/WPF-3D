using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNrrdReader
	/// </summary>
	/// <remarks>
	///    Read nrrd files file system
	///
	///
	///
	///
	/// @bug
	/// There are several limitations on what type of nrrd files we can read.  This
	/// reader only supports nrrd files in raw, ascii and gzip format.  Other encodings
	/// like hex will result in errors.  When reading in detached headers, this only
	/// supports reading one file that is detached.
	///
	/// </remarks>
	// Token: 0x02000799 RID: 1945
	public class vtkNrrdReader : vtkImageReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013FAC RID: 81836 RVA: 0x001C37F7 File Offset: 0x001C19F7
		static vtkNrrdReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNrrdReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNrrdReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013FAD RID: 81837 RVA: 0x001C381F File Offset: 0x001C1A1F
		public vtkNrrdReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013FAE RID: 81838
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNrrdReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FAF RID: 81839 RVA: 0x001C3830 File Offset: 0x001C1A30
		public new static vtkNrrdReader New()
		{
			vtkNrrdReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNrrdReader.vtkNrrdReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNrrdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FB0 RID: 81840 RVA: 0x001C3884 File Offset: 0x001C1A84
		public vtkNrrdReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNrrdReader.vtkNrrdReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013FB1 RID: 81841 RVA: 0x001C38C8 File Offset: 0x001C1AC8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013FB2 RID: 81842
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNrrdReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string filename);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FB3 RID: 81843 RVA: 0x001C38D4 File Offset: 0x001C1AD4
		public override int CanReadFile(string filename)
		{
			return vtkNrrdReader.vtkNrrdReader_CanReadFile_01(base.GetCppThis(), filename);
		}

		// Token: 0x06013FB4 RID: 81844
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNrrdReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FB5 RID: 81845 RVA: 0x001C38F4 File Offset: 0x001C1AF4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNrrdReader.vtkNrrdReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013FB6 RID: 81846
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNrrdReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FB7 RID: 81847 RVA: 0x001C3914 File Offset: 0x001C1B14
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNrrdReader.vtkNrrdReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013FB8 RID: 81848
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNrrdReader_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FB9 RID: 81849 RVA: 0x001C3930 File Offset: 0x001C1B30
		public override int IsA(string type)
		{
			return vtkNrrdReader.vtkNrrdReader_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013FBA RID: 81850
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNrrdReader_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FBB RID: 81851 RVA: 0x001C3950 File Offset: 0x001C1B50
		public new static int IsTypeOf(string type)
		{
			return vtkNrrdReader.vtkNrrdReader_IsTypeOf_05(type);
		}

		// Token: 0x06013FBC RID: 81852
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNrrdReader_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FBD RID: 81853 RVA: 0x001C396C File Offset: 0x001C1B6C
		public new vtkNrrdReader NewInstance()
		{
			vtkNrrdReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNrrdReader.vtkNrrdReader_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNrrdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013FBE RID: 81854
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNrrdReader_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013FBF RID: 81855 RVA: 0x001C39C8 File Offset: 0x001C1BC8
		public new static vtkNrrdReader SafeDownCast(vtkObjectBase o)
		{
			vtkNrrdReader vtkNrrdReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNrrdReader.vtkNrrdReader_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNrrdReader = (vtkNrrdReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNrrdReader.Register(null);
				}
			}
			return vtkNrrdReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001732 RID: 5938
		public new const string MRFullTypeName = "Kitware.VTK.vtkNrrdReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001733 RID: 5939
		public new static readonly string MRClassNameKey = "class vtkNrrdReader";
	}
}
