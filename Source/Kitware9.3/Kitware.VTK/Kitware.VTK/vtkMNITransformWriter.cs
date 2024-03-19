using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMNITransformWriter
	/// </summary>
	/// <remarks>
	///    A writer for MNI transformation files.
	///
	/// The MNI .xfm file format is used to store geometrical
	/// transformations.  Three kinds of transformations are supported by
	/// the file format: affine, thin-plate spline, and grid transformations.
	/// This file format was developed at the McConnell Brain Imaging Centre
	/// at the Montreal Neurological Institute and is used by their software.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageWriter vtkMNITransformReader
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x02000180 RID: 384
	public class vtkMNITransformWriter : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06004934 RID: 18740 RVA: 0x0006AF87 File Offset: 0x00069187
		static vtkMNITransformWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMNITransformWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNITransformWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06004935 RID: 18741 RVA: 0x0006AFAF File Offset: 0x000691AF
		public vtkMNITransformWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06004936 RID: 18742
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004937 RID: 18743 RVA: 0x0006AFC0 File Offset: 0x000691C0
		public new static vtkMNITransformWriter New()
		{
			vtkMNITransformWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004938 RID: 18744 RVA: 0x0006B014 File Offset: 0x00069214
		public vtkMNITransformWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMNITransformWriter.vtkMNITransformWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06004939 RID: 18745 RVA: 0x0006B058 File Offset: 0x00069258
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600493A RID: 18746
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformWriter_AddTransform_01(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Add another transform to the file.  The next time that
		/// SetTransform is called, all added transforms will be
		/// removed.
		/// </summary>
		// Token: 0x0600493B RID: 18747 RVA: 0x0006B064 File Offset: 0x00069264
		public virtual void AddTransform(vtkAbstractTransform transform)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_AddTransform_01(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0600493C RID: 18748
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_GetComments_02(HandleRef pThis);

		/// <summary>
		/// Set comments to be added to the file.
		/// </summary>
		// Token: 0x0600493D RID: 18749 RVA: 0x0006B094 File Offset: 0x00069294
		public virtual string GetComments()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetComments_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600493E RID: 18750
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_GetDescriptiveName_03(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x0600493F RID: 18751 RVA: 0x0006B0D0 File Offset: 0x000692D0
		public virtual string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetDescriptiveName_03(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004940 RID: 18752
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_GetFileExtensions_04(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x06004941 RID: 18753 RVA: 0x0006B10C File Offset: 0x0006930C
		public virtual string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetFileExtensions_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004942 RID: 18754
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_GetFileName_05(HandleRef pThis);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004943 RID: 18755 RVA: 0x0006B148 File Offset: 0x00069348
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMNITransformWriter.vtkMNITransformWriter_GetFileName_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06004944 RID: 18756
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITransformWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004945 RID: 18757 RVA: 0x0006B184 File Offset: 0x00069384
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06004946 RID: 18758
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMNITransformWriter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004947 RID: 18759 RVA: 0x0006B1A4 File Offset: 0x000693A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06004948 RID: 18760
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformWriter_GetNumberOfTransforms_08(HandleRef pThis);

		/// <summary>
		/// Get the number of transforms that will be written.
		/// </summary>
		// Token: 0x06004949 RID: 18761 RVA: 0x0006B1C0 File Offset: 0x000693C0
		public virtual int GetNumberOfTransforms()
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_GetNumberOfTransforms_08(base.GetCppThis());
		}

		// Token: 0x0600494A RID: 18762
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_GetTransform_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the transform.
		/// </summary>
		// Token: 0x0600494B RID: 18763 RVA: 0x0006B1E0 File Offset: 0x000693E0
		public virtual vtkAbstractTransform GetTransform()
		{
			vtkAbstractTransform vtkAbstractTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_GetTransform_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600494C RID: 18764
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformWriter_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600494D RID: 18765 RVA: 0x0006B250 File Offset: 0x00069450
		public override int IsA(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600494E RID: 18766
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMNITransformWriter_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600494F RID: 18767 RVA: 0x0006B270 File Offset: 0x00069470
		public new static int IsTypeOf(string type)
		{
			return vtkMNITransformWriter.vtkMNITransformWriter_IsTypeOf_11(type);
		}

		// Token: 0x06004950 RID: 18768
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004951 RID: 18769 RVA: 0x0006B28C File Offset: 0x0006948C
		public new vtkMNITransformWriter NewInstance()
		{
			vtkMNITransformWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004952 RID: 18770
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMNITransformWriter_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004953 RID: 18771 RVA: 0x0006B2E8 File Offset: 0x000694E8
		public new static vtkMNITransformWriter SafeDownCast(vtkObjectBase o)
		{
			vtkMNITransformWriter vtkMNITransformWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMNITransformWriter.vtkMNITransformWriter_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMNITransformWriter = (vtkMNITransformWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMNITransformWriter.Register(null);
				}
			}
			return vtkMNITransformWriter;
		}

		// Token: 0x06004954 RID: 18772
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformWriter_SetComments_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set comments to be added to the file.
		/// </summary>
		// Token: 0x06004955 RID: 18773 RVA: 0x0006B367 File Offset: 0x00069567
		public virtual void SetComments(string _arg)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetComments_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06004956 RID: 18774
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformWriter_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x06004957 RID: 18775 RVA: 0x0006B377 File Offset: 0x00069577
		public virtual void SetFileName(string _arg)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetFileName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06004958 RID: 18776
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformWriter_SetTransform_17(HandleRef pThis, HandleRef transform);

		/// <summary>
		/// Set the transform.
		/// </summary>
		// Token: 0x06004959 RID: 18777 RVA: 0x0006B388 File Offset: 0x00069588
		public virtual void SetTransform(vtkAbstractTransform transform)
		{
			vtkMNITransformWriter.vtkMNITransformWriter_SetTransform_17(base.GetCppThis(), (transform == null) ? default(HandleRef) : transform.GetCppThis());
		}

		// Token: 0x0600495A RID: 18778
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMNITransformWriter_Write_18(HandleRef pThis);

		/// <summary>
		/// Write the file.
		/// </summary>
		// Token: 0x0600495B RID: 18779 RVA: 0x0006B3B7 File Offset: 0x000695B7
		public virtual void Write()
		{
			vtkMNITransformWriter.vtkMNITransformWriter_Write_18(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000751 RID: 1873
		public new const string MRFullTypeName = "Kitware.VTK.vtkMNITransformWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000752 RID: 1874
		public new static readonly string MRClassNameKey = "class vtkMNITransformWriter";
	}
}
