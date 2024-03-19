using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMINCImageReader
	/// </summary>
	/// <remarks>
	///    A reader for MINC files.
	///
	/// MINC is a NetCDF-based medical image file format that was developed
	/// at the Montreal Neurological Institute in 1992.
	/// This class will read a MINC file into VTK, rearranging the data to
	/// match the VTK x, y, and z dimensions, and optionally rescaling
	/// real-valued data to VTK_FLOAT if RescaleRealValuesOn() is set.
	/// If RescaleRealValues is off, then the data will be stored in its
	/// original data type and the GetRescaleSlope(), GetRescaleIntercept()
	/// method can be used to retrieve global rescaling parameters.
	/// If the original file had a time dimension, the SetTimeStep() method
	/// can be used to specify a time step to read.
	/// All of the original header information can be accessed though the
	/// GetImageAttributes() method.
	/// </remarks>
	/// <seealso>
	///
	/// vtkMINCImageWriter vtkMINCImageAttributes
	/// @par Thanks:
	/// Thanks to David Gobbi for writing this class and Atamai Inc. for
	/// contributing it to VTK.
	/// </seealso>
	// Token: 0x02000179 RID: 377
	public class vtkMINCImageReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060047EC RID: 18412 RVA: 0x00068A34 File Offset: 0x00066C34
		static vtkMINCImageReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMINCImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060047ED RID: 18413 RVA: 0x00068A5C File Offset: 0x00066C5C
		public vtkMINCImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060047EE RID: 18414
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047EF RID: 18415 RVA: 0x00068A6C File Offset: 0x00066C6C
		public new static vtkMINCImageReader New()
		{
			vtkMINCImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060047F0 RID: 18416 RVA: 0x00068AC0 File Offset: 0x00066CC0
		public vtkMINCImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMINCImageReader.vtkMINCImageReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060047F1 RID: 18417 RVA: 0x00068B04 File Offset: 0x00066D04
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060047F2 RID: 18418
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Test whether the specified file can be read.
		/// </summary>
		// Token: 0x060047F3 RID: 18419 RVA: 0x00068B10 File Offset: 0x00066D10
		public override int CanReadFile(string name)
		{
			return vtkMINCImageReader.vtkMINCImageReader_CanReadFile_01(base.GetCppThis(), name);
		}

		// Token: 0x060047F4 RID: 18420
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_GetDataRange_02(HandleRef pThis);

		/// <summary>
		/// Get the scalar range of the output from the information in
		/// the file header.  This is more efficient that computing the
		/// scalar range, but in some cases the MINC file stores an
		/// incorrect valid_range and the DataRange will be incorrect.
		/// </summary>
		// Token: 0x060047F5 RID: 18421 RVA: 0x00068B30 File Offset: 0x00066D30
		public virtual double[] GetDataRange()
		{
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetDataRange_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060047F6 RID: 18422
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_GetDataRange_03(HandleRef pThis, IntPtr range);

		/// <summary>
		/// Get the scalar range of the output from the information in
		/// the file header.  This is more efficient that computing the
		/// scalar range, but in some cases the MINC file stores an
		/// incorrect valid_range and the DataRange will be incorrect.
		/// </summary>
		// Token: 0x060047F7 RID: 18423 RVA: 0x00068B78 File Offset: 0x00066D78
		public virtual void GetDataRange(IntPtr range)
		{
			vtkMINCImageReader.vtkMINCImageReader_GetDataRange_03(base.GetCppThis(), range);
		}

		// Token: 0x060047F8 RID: 18424
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_GetDescriptiveName_04(HandleRef pThis);

		/// <summary>
		/// Get the name of this file format.
		/// </summary>
		// Token: 0x060047F9 RID: 18425 RVA: 0x00068B88 File Offset: 0x00066D88
		public override string GetDescriptiveName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageReader.vtkMINCImageReader_GetDescriptiveName_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060047FA RID: 18426
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_GetDirectionCosines_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get a matrix that describes the orientation of the data.
		/// The three columns of the matrix are the direction cosines
		/// for the x, y and z dimensions respectively.
		/// </summary>
		// Token: 0x060047FB RID: 18427 RVA: 0x00068BC4 File Offset: 0x00066DC4
		public virtual vtkMatrix4x4 GetDirectionCosines()
		{
			vtkMatrix4x4 vtkMatrix4x = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetDirectionCosines_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatrix4x = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatrix4x.Register(null);
				}
			}
			return vtkMatrix4x;
		}

		// Token: 0x060047FC RID: 18428
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_GetFileExtensions_06(HandleRef pThis);

		/// <summary>
		/// Get the extension for this file format.
		/// </summary>
		// Token: 0x060047FD RID: 18429 RVA: 0x00068C34 File Offset: 0x00066E34
		public override string GetFileExtensions()
		{
			string s = Marshal.PtrToStringAnsi(vtkMINCImageReader.vtkMINCImageReader_GetFileExtensions_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060047FE RID: 18430
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_GetImageAttributes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the image attributes, which contain patient information and
		/// other useful metadata.
		/// </summary>
		// Token: 0x060047FF RID: 18431 RVA: 0x00068C70 File Offset: 0x00066E70
		public virtual vtkMINCImageAttributes GetImageAttributes()
		{
			vtkMINCImageAttributes vtkMINCImageAttributes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_GetImageAttributes_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageAttributes = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageAttributes.Register(null);
				}
			}
			return vtkMINCImageAttributes;
		}

		// Token: 0x06004800 RID: 18432
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004801 RID: 18433 RVA: 0x00068CE0 File Offset: 0x00066EE0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06004802 RID: 18434
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMINCImageReader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004803 RID: 18435 RVA: 0x00068D00 File Offset: 0x00066F00
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06004804 RID: 18436
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_GetNumberOfTimeSteps_10(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps in the file.
		/// </summary>
		// Token: 0x06004805 RID: 18437 RVA: 0x00068D1C File Offset: 0x00066F1C
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetNumberOfTimeSteps_10(base.GetCppThis());
		}

		// Token: 0x06004806 RID: 18438
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMINCImageReader_GetRescaleIntercept_11(HandleRef pThis);

		/// <summary>
		/// Get the slope and intercept for rescaling the scalar values
		/// to real data values.  To convert scalar values to real values,
		/// use the equation y = x*RescaleSlope + RescaleIntercept.
		/// </summary>
		// Token: 0x06004807 RID: 18439 RVA: 0x00068D3C File Offset: 0x00066F3C
		public virtual double GetRescaleIntercept()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleIntercept_11(base.GetCppThis());
		}

		// Token: 0x06004808 RID: 18440
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_GetRescaleRealValues_12(HandleRef pThis);

		/// <summary>
		/// Rescale real data values to float.  If this is done, the
		/// RescaleSlope and RescaleIntercept will be set to 1 and 0
		/// respectively.  This is off by default.
		/// </summary>
		// Token: 0x06004809 RID: 18441 RVA: 0x00068D5C File Offset: 0x00066F5C
		public virtual int GetRescaleRealValues()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleRealValues_12(base.GetCppThis());
		}

		// Token: 0x0600480A RID: 18442
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMINCImageReader_GetRescaleSlope_13(HandleRef pThis);

		/// <summary>
		/// Get the slope and intercept for rescaling the scalar values
		/// to real data values.  To convert scalar values to real values,
		/// use the equation y = x*RescaleSlope + RescaleIntercept.
		/// </summary>
		// Token: 0x0600480B RID: 18443 RVA: 0x00068D7C File Offset: 0x00066F7C
		public virtual double GetRescaleSlope()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetRescaleSlope_13(base.GetCppThis());
		}

		// Token: 0x0600480C RID: 18444
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_GetTimeStep_14(HandleRef pThis);

		/// <summary>
		/// Set the time step to read.
		/// </summary>
		// Token: 0x0600480D RID: 18445 RVA: 0x00068D9C File Offset: 0x00066F9C
		public virtual int GetTimeStep()
		{
			return vtkMINCImageReader.vtkMINCImageReader_GetTimeStep_14(base.GetCppThis());
		}

		// Token: 0x0600480E RID: 18446
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600480F RID: 18447 RVA: 0x00068DBC File Offset: 0x00066FBC
		public override int IsA(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x06004810 RID: 18448
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMINCImageReader_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004811 RID: 18449 RVA: 0x00068DDC File Offset: 0x00066FDC
		public new static int IsTypeOf(string type)
		{
			return vtkMINCImageReader.vtkMINCImageReader_IsTypeOf_16(type);
		}

		// Token: 0x06004812 RID: 18450
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004813 RID: 18451 RVA: 0x00068DF8 File Offset: 0x00066FF8
		public new vtkMINCImageReader NewInstance()
		{
			vtkMINCImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06004814 RID: 18452
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_RescaleRealValuesOff_19(HandleRef pThis);

		/// <summary>
		/// Rescale real data values to float.  If this is done, the
		/// RescaleSlope and RescaleIntercept will be set to 1 and 0
		/// respectively.  This is off by default.
		/// </summary>
		// Token: 0x06004815 RID: 18453 RVA: 0x00068E52 File Offset: 0x00067052
		public virtual void RescaleRealValuesOff()
		{
			vtkMINCImageReader.vtkMINCImageReader_RescaleRealValuesOff_19(base.GetCppThis());
		}

		// Token: 0x06004816 RID: 18454
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_RescaleRealValuesOn_20(HandleRef pThis);

		/// <summary>
		/// Rescale real data values to float.  If this is done, the
		/// RescaleSlope and RescaleIntercept will be set to 1 and 0
		/// respectively.  This is off by default.
		/// </summary>
		// Token: 0x06004817 RID: 18455 RVA: 0x00068E61 File Offset: 0x00067061
		public virtual void RescaleRealValuesOn()
		{
			vtkMINCImageReader.vtkMINCImageReader_RescaleRealValuesOn_20(base.GetCppThis());
		}

		// Token: 0x06004818 RID: 18456
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMINCImageReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06004819 RID: 18457 RVA: 0x00068E70 File Offset: 0x00067070
		public new static vtkMINCImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkMINCImageReader vtkMINCImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMINCImageReader.vtkMINCImageReader_SafeDownCast_21((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMINCImageReader = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMINCImageReader.Register(null);
				}
			}
			return vtkMINCImageReader;
		}

		// Token: 0x0600481A RID: 18458
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_SetFileName_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Set the file name.
		/// </summary>
		// Token: 0x0600481B RID: 18459 RVA: 0x00068EEF File Offset: 0x000670EF
		public override void SetFileName(string name)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetFileName_22(base.GetCppThis(), name);
		}

		// Token: 0x0600481C RID: 18460
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_SetRescaleRealValues_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Rescale real data values to float.  If this is done, the
		/// RescaleSlope and RescaleIntercept will be set to 1 and 0
		/// respectively.  This is off by default.
		/// </summary>
		// Token: 0x0600481D RID: 18461 RVA: 0x00068EFF File Offset: 0x000670FF
		public virtual void SetRescaleRealValues(int _arg)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetRescaleRealValues_23(base.GetCppThis(), _arg);
		}

		// Token: 0x0600481E RID: 18462
		[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMINCImageReader_SetTimeStep_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the time step to read.
		/// </summary>
		// Token: 0x0600481F RID: 18463 RVA: 0x00068F0F File Offset: 0x0006710F
		public virtual void SetTimeStep(int _arg)
		{
			vtkMINCImageReader.vtkMINCImageReader_SetTimeStep_24(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000743 RID: 1859
		public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000744 RID: 1860
		public new static readonly string MRClassNameKey = "class vtkMINCImageReader";
	}
}
