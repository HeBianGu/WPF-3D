using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageReader
	/// </summary>
	/// <remarks>
	///    Superclass of transformable binary file readers.
	///
	/// vtkImageReader provides methods needed to read a region from a file.
	/// It supports both transforms and masks on the input data, but as a result
	/// is more complicated and slower than its parent class vtkImageReader2.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkBMPReader vtkPNMReader vtkTIFFReader
	/// </seealso>
	// Token: 0x0200075B RID: 1883
	public class vtkImageReader : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060138E9 RID: 80105 RVA: 0x001BA279 File Offset: 0x001B8479
		static vtkImageReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060138EA RID: 80106 RVA: 0x001BA2A1 File Offset: 0x001B84A1
		public vtkImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060138EB RID: 80107
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138EC RID: 80108 RVA: 0x001BA2B0 File Offset: 0x001B84B0
		public new static vtkImageReader New()
		{
			vtkImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader.vtkImageReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138ED RID: 80109 RVA: 0x001BA304 File Offset: 0x001B8504
		public vtkImageReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageReader.vtkImageReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060138EE RID: 80110 RVA: 0x001BA348 File Offset: 0x001B8548
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060138EF RID: 80111
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader_CanReadFile_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// vtkImageReader itself can read raw binary files. That being the case,
		/// we need to implement `CanReadFile` to return success for any file.
		/// Subclasses that read specific file format should override and implement
		/// appropriate checks for file format.
		/// </summary>
		// Token: 0x060138F0 RID: 80112 RVA: 0x001BA354 File Offset: 0x001B8554
		public override int CanReadFile(string arg0)
		{
			return vtkImageReader.vtkImageReader_CanReadFile_01(base.GetCppThis(), arg0);
		}

		// Token: 0x060138F1 RID: 80113
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_ComputeInverseTransformedExtent_02(HandleRef pThis, IntPtr inExtent, IntPtr outExtent);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x060138F2 RID: 80114 RVA: 0x001BA374 File Offset: 0x001B8574
		public void ComputeInverseTransformedExtent(IntPtr inExtent, IntPtr outExtent)
		{
			vtkImageReader.vtkImageReader_ComputeInverseTransformedExtent_02(base.GetCppThis(), inExtent, outExtent);
		}

		// Token: 0x060138F3 RID: 80115
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_ComputeInverseTransformedIncrements_03(HandleRef pThis, IntPtr inIncr, IntPtr outIncr);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x060138F4 RID: 80116 RVA: 0x001BA385 File Offset: 0x001B8585
		public void ComputeInverseTransformedIncrements(IntPtr inIncr, IntPtr outIncr)
		{
			vtkImageReader.vtkImageReader_ComputeInverseTransformedIncrements_03(base.GetCppThis(), inIncr, outIncr);
		}

		// Token: 0x060138F5 RID: 80117
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageReader_GetDataMask_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the Data mask.  The data mask is a simply integer whose bits are
		/// treated as a mask to the bits read from disk.  That is, the data mask is
		/// bitwise-and'ed to the numbers read from disk.  This ivar is stored as 64
		/// bits, the largest mask you will need.  The mask will be truncated to the
		/// data size required to be read (using the least significant bits).
		/// </summary>
		// Token: 0x060138F6 RID: 80118 RVA: 0x001BA398 File Offset: 0x001B8598
		public virtual ulong GetDataMask()
		{
			return vtkImageReader.vtkImageReader_GetDataMask_04(base.GetCppThis());
		}

		// Token: 0x060138F7 RID: 80119
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_GetDataVOI_05(HandleRef pThis);

		/// <summary>
		/// Set/get the data VOI. You can limit the reader to only
		/// read a subset of the data.
		/// </summary>
		// Token: 0x060138F8 RID: 80120 RVA: 0x001BA3B8 File Offset: 0x001B85B8
		public virtual int[] GetDataVOI()
		{
			IntPtr intPtr = vtkImageReader.vtkImageReader_GetDataVOI_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x060138F9 RID: 80121
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_GetDataVOI_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set/get the data VOI. You can limit the reader to only
		/// read a subset of the data.
		/// </summary>
		// Token: 0x060138FA RID: 80122 RVA: 0x001BA400 File Offset: 0x001B8600
		public virtual void GetDataVOI(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkImageReader.vtkImageReader_GetDataVOI_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x060138FB RID: 80123
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_GetDataVOI_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the data VOI. You can limit the reader to only
		/// read a subset of the data.
		/// </summary>
		// Token: 0x060138FC RID: 80124 RVA: 0x001BA418 File Offset: 0x001B8618
		public virtual void GetDataVOI(IntPtr _arg)
		{
			vtkImageReader.vtkImageReader_GetDataVOI_07(base.GetCppThis(), _arg);
		}

		// Token: 0x060138FD RID: 80125
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138FE RID: 80126 RVA: 0x001BA428 File Offset: 0x001B8628
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageReader.vtkImageReader_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x060138FF RID: 80127
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013900 RID: 80128 RVA: 0x001BA448 File Offset: 0x001B8648
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageReader.vtkImageReader_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06013901 RID: 80129
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_GetScalarArrayName_10(HandleRef pThis);

		/// <summary>
		/// Set/get the scalar array name for this data set.
		/// </summary>
		// Token: 0x06013902 RID: 80130 RVA: 0x001BA464 File Offset: 0x001B8664
		public virtual string GetScalarArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageReader.vtkImageReader_GetScalarArrayName_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013903 RID: 80131
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_GetTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x06013904 RID: 80132 RVA: 0x001BA4A0 File Offset: 0x001B86A0
		public virtual vtkTransform GetTransform()
		{
			vtkTransform vtkTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader.vtkImageReader_GetTransform_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTransform = (vtkTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTransform.Register(null);
				}
			}
			return vtkTransform;
		}

		// Token: 0x06013905 RID: 80133
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013906 RID: 80134 RVA: 0x001BA510 File Offset: 0x001B8710
		public override int IsA(string type)
		{
			return vtkImageReader.vtkImageReader_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06013907 RID: 80135
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013908 RID: 80136 RVA: 0x001BA530 File Offset: 0x001B8730
		public new static int IsTypeOf(string type)
		{
			return vtkImageReader.vtkImageReader_IsTypeOf_13(type);
		}

		// Token: 0x06013909 RID: 80137
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601390A RID: 80138 RVA: 0x001BA54C File Offset: 0x001B874C
		public new vtkImageReader NewInstance()
		{
			vtkImageReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader.vtkImageReader_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601390B RID: 80139
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader_OpenAndSeekFile_16(HandleRef pThis, IntPtr extent, int slice);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x0601390C RID: 80140 RVA: 0x001BA5A8 File Offset: 0x001B87A8
		public int OpenAndSeekFile(IntPtr extent, int slice)
		{
			return vtkImageReader.vtkImageReader_OpenAndSeekFile_16(base.GetCppThis(), extent, slice);
		}

		// Token: 0x0601390D RID: 80141
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601390E RID: 80142 RVA: 0x001BA5CC File Offset: 0x001B87CC
		public new static vtkImageReader SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader vtkImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader.vtkImageReader_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		// Token: 0x0601390F RID: 80143
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_SetDataMask_18(HandleRef pThis, ulong _arg);

		/// <summary>
		/// Set/Get the Data mask.  The data mask is a simply integer whose bits are
		/// treated as a mask to the bits read from disk.  That is, the data mask is
		/// bitwise-and'ed to the numbers read from disk.  This ivar is stored as 64
		/// bits, the largest mask you will need.  The mask will be truncated to the
		/// data size required to be read (using the least significant bits).
		/// </summary>
		// Token: 0x06013910 RID: 80144 RVA: 0x001BA64B File Offset: 0x001B884B
		public virtual void SetDataMask(ulong _arg)
		{
			vtkImageReader.vtkImageReader_SetDataMask_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06013911 RID: 80145
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_SetDataVOI_19(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set/get the data VOI. You can limit the reader to only
		/// read a subset of the data.
		/// </summary>
		// Token: 0x06013912 RID: 80146 RVA: 0x001BA65B File Offset: 0x001B885B
		public virtual void SetDataVOI(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkImageReader.vtkImageReader_SetDataVOI_19(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x06013913 RID: 80147
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_SetDataVOI_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/get the data VOI. You can limit the reader to only
		/// read a subset of the data.
		/// </summary>
		// Token: 0x06013914 RID: 80148 RVA: 0x001BA673 File Offset: 0x001B8873
		public virtual void SetDataVOI(IntPtr _arg)
		{
			vtkImageReader.vtkImageReader_SetDataVOI_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06013915 RID: 80149
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_SetScalarArrayName_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set/get the scalar array name for this data set.
		/// </summary>
		// Token: 0x06013916 RID: 80150 RVA: 0x001BA683 File Offset: 0x001B8883
		public virtual void SetScalarArrayName(string _arg)
		{
			vtkImageReader.vtkImageReader_SetScalarArrayName_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06013917 RID: 80151
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader_SetTransform_22(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get transformation matrix to transform the data from slice space
		/// into world space. This matrix must be a permutation matrix. To qualify,
		/// the sums of the rows must be + or - 1.
		/// </summary>
		// Token: 0x06013918 RID: 80152 RVA: 0x001BA694 File Offset: 0x001B8894
		public virtual void SetTransform(vtkTransform arg0)
		{
			vtkImageReader.vtkImageReader_SetTransform_22(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001693 RID: 5779
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001694 RID: 5780
		public new static readonly string MRClassNameKey = "class vtkImageReader";
	}
}
