using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNITransformReader
	/// </summary>
	/// <remarks>
	///    A reader for MNI transformation files.
	///
	/// The MNI .xfm file format is used to store geometrical
	/// transformations.  Three kinds of transformations are supported by
	/// the file format: affine, thin-plate spline, and grid transformations.
	/// This file format was developed at the McConnell Brain Imaging Centre
	/// at the Montreal Neurological Institute and is used by their software.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMNITransformWriter
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x0200017F RID: 383
	public class vtkMNITransformReader : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004910 RID: 18704 RVA: 0x0006AB37 File Offset: 0x00068D37
		static vtkMNITransformReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITransformReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITransformReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004911 RID: 18705 RVA: 0x0006AB5F File Offset: 0x00068D5F
		public vtkMNITransformReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004912 RID: 18706
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004913 RID: 18707 RVA: 0x0006AB70 File Offset: 0x00068D70
		public new static vtkMNITransformReader New()
		{
			vtkMNITransformReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004914 RID: 18708 RVA: 0x0006ABC4 File Offset: 0x00068DC4
		public vtkMNITransformReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNITransformReader.vtkMNITransformReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004915 RID: 18709 RVA: 0x0006AC08 File Offset: 0x00068E08
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06004916 RID: 18710
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the specified file can be read.
		/// </summary>
		// Token: 0x06004917 RID: 18711 RVA: 0x0006AC14 File Offset: 0x00068E14
		public virtual int CanReadFile(string name)
		{
			return vtkMNITransformReader.vtkMNITransformReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x06004918 RID: 18712
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetComments_02(HandleRef pThis);

		/// <summary>
		/// Get any comments that are included in the file.
		/// </summary>
		// Token: 0x06004919 RID: 18713 RVA: 0x0006AC34 File Offset: 0x00068E34
		public virtual string GetComments()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetComments_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600491A RID: 18714
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetDescriptiveName_03(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x0600491B RID: 18715 RVA: 0x0006AC70 File Offset: 0x00068E70
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetDescriptiveName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600491C RID: 18716
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetFileExtensions_04(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x0600491D RID: 18717 RVA: 0x0006ACAC File Offset: 0x00068EAC
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetFileExtensions_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600491E RID: 18718
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x0600491F RID: 18719 RVA: 0x0006ACE8 File Offset: 0x00068EE8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformReader.vtkMNITransformReader_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004920 RID: 18720
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetNthTransform_06(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get one of the transforms listed in the file.
		/// </summary>
		// Token: 0x06004921 RID: 18721 RVA: 0x0006AD24 File Offset: 0x00068F24
		public virtual vtkAbstractTransform GetNthTransform(int i)
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_GetNthTransform_06(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x06004922 RID: 18722
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITransformReader_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004923 RID: 18723 RVA: 0x0006AD94 File Offset: 0x00068F94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06004924 RID: 18724
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITransformReader_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004925 RID: 18725 RVA: 0x0006ADB4 File Offset: 0x00068FB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06004926 RID: 18726
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformReader_GetNumberOfTransforms_09(HandleRef pThis);

		/// <summary>
		/// Get the number of transforms in the file.
		/// </summary>
		// Token: 0x06004927 RID: 18727 RVA: 0x0006ADD0 File Offset: 0x00068FD0
		public virtual int GetNumberOfTransforms()
		{
			return vtkMNITransformReader.vtkMNITransformReader_GetNumberOfTransforms_09(base.GetCppThis());
		}

		// Token: 0x06004928 RID: 18728
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_GetTransform_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform that results from concatenating all
		/// of the transforms in the file.  This will return null
		/// if you have not specified a file name.
		/// </summary>
		// Token: 0x06004929 RID: 18729 RVA: 0x0006ADF0 File Offset: 0x00068FF0
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_GetTransform_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractTransform = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractTransform.Register(null);
				}
			}
			return vtkAbstractTransform;
		}

		// Token: 0x0600492A RID: 18730
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformReader_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600492B RID: 18731 RVA: 0x0006AE60 File Offset: 0x00069060
		public override int IsA(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600492C RID: 18732
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformReader_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600492D RID: 18733 RVA: 0x0006AE80 File Offset: 0x00069080
		public new static int IsTypeOf(string type)
		{
			return vtkMNITransformReader.vtkMNITransformReader_IsTypeOf_12(type);
		}

		// Token: 0x0600492E RID: 18734
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600492F RID: 18735 RVA: 0x0006AE9C File Offset: 0x0006909C
		public new vtkMNITransformReader NewInstance()
		{
			vtkMNITransformReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004930 RID: 18736
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004931 RID: 18737 RVA: 0x0006AEF8 File Offset: 0x000690F8
		public new static vtkMNITransformReader SafeDownCast(vtkObjectBase o)
		{
			vtkMNITransformReader vtkMNITransformReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformReader.vtkMNITransformReader_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITransformReader = (vtkMNITransformReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITransformReader.Register(null);
				}
			}
			return vtkMNITransformReader;
		}

		// Token: 0x06004932 RID: 18738
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformReader_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004933 RID: 18739 RVA: 0x0006AF77 File Offset: 0x00069177
		public virtual void SetFileName(string _arg)
		{
			vtkMNITransformReader.vtkMNITransformReader_SetFileName_16(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400074F RID: 1871
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITransformReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000750 RID: 1872
		public new static readonly string MRClassNameKey = "class vtkMNITransformReader";
	}
}
