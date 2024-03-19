using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNIObjectReader
	/// </summary>
	/// <remarks>
	///    A reader for MNI surface mesh files.
	///
	/// The MNI .obj file format is used to store geometrical data.  This
	/// file format was developed at the McConnell Brain Imaging Centre at
	/// the Montreal Neurological Institute and is used by their software.
	/// Only polygon and line files are supported by this reader, but for
	/// those formats, all data elements are read including normals, colors,
	/// and surface properties.  ASCII and binary file types are supported.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageReader vtkMNIObjectWriter vtkMNITransformReader
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x0200017B RID: 379
	public class vtkMNIObjectReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004856 RID: 18518 RVA: 0x00069420 File Offset: 0x00067620
		static vtkMNIObjectReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNIObjectReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNIObjectReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004857 RID: 18519 RVA: 0x00069448 File Offset: 0x00067648
		public vtkMNIObjectReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004858 RID: 18520
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004859 RID: 18521 RVA: 0x00069458 File Offset: 0x00067658
		public new static vtkMNIObjectReader New()
		{
			vtkMNIObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600485A RID: 18522 RVA: 0x000694AC File Offset: 0x000676AC
		public vtkMNIObjectReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNIObjectReader.vtkMNIObjectReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600485B RID: 18523 RVA: 0x000694F0 File Offset: 0x000676F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600485C RID: 18524
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the specified file can be read.
		/// </summary>
		// Token: 0x0600485D RID: 18525 RVA: 0x000694FC File Offset: 0x000676FC
		public virtual int CanReadFile(string name)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x0600485E RID: 18526
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_GetDescriptiveName_02(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x0600485F RID: 18527 RVA: 0x0006951C File Offset: 0x0006771C
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetDescriptiveName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004860 RID: 18528
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_GetFileExtensions_03(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x06004861 RID: 18529 RVA: 0x00069558 File Offset: 0x00067758
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetFileExtensions_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004862 RID: 18530
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_GetFileName_04(HandleRef pThis);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004863 RID: 18531 RVA: 0x00069594 File Offset: 0x00067794
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNIObjectReader.vtkMNIObjectReader_GetFileName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004864 RID: 18532
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNIObjectReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004865 RID: 18533 RVA: 0x000695D0 File Offset: 0x000677D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06004866 RID: 18534
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNIObjectReader_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004867 RID: 18535 RVA: 0x000695F0 File Offset: 0x000677F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06004868 RID: 18536
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_GetProperty_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the property associated with the object.
		/// </summary>
		// Token: 0x06004869 RID: 18537 RVA: 0x0006960C File Offset: 0x0006780C
		public virtual vtkProperty GetProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_GetProperty_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProperty = (vtkProperty)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProperty.Register(null);
				}
			}
			return vtkProperty;
		}

		// Token: 0x0600486A RID: 18538
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectReader_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600486B RID: 18539 RVA: 0x0006967C File Offset: 0x0006787C
		public override int IsA(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0600486C RID: 18540
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNIObjectReader_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600486D RID: 18541 RVA: 0x0006969C File Offset: 0x0006789C
		public new static int IsTypeOf(string type)
		{
			return vtkMNIObjectReader.vtkMNIObjectReader_IsTypeOf_09(type);
		}

		// Token: 0x0600486E RID: 18542
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600486F RID: 18543 RVA: 0x000696B8 File Offset: 0x000678B8
		public new vtkMNIObjectReader NewInstance()
		{
			vtkMNIObjectReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004870 RID: 18544
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNIObjectReader_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004871 RID: 18545 RVA: 0x00069714 File Offset: 0x00067914
		public new static vtkMNIObjectReader SafeDownCast(vtkObjectBase o)
		{
			vtkMNIObjectReader vtkMNIObjectReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNIObjectReader.vtkMNIObjectReader_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNIObjectReader = (vtkMNIObjectReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNIObjectReader.Register(null);
				}
			}
			return vtkMNIObjectReader;
		}

		// Token: 0x06004872 RID: 18546
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNIObjectReader_SetFileName_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004873 RID: 18547 RVA: 0x00069793 File Offset: 0x00067993
		public virtual void SetFileName(string _arg)
		{
			vtkMNIObjectReader.vtkMNIObjectReader_SetFileName_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000747 RID: 1863
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNIObjectReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000748 RID: 1864
		public new static readonly string MRClassNameKey = "class vtkMNIObjectReader";
	}
}
