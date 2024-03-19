using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkParticleReader
	/// </summary>
	/// <remarks>
	///    Read ASCII or binary particle
	///                            data and (optionally) one scalar
	///                            value associated with each particle.
	///
	/// vtkParticleReader reads either a binary or a text file of
	///  particles. Each particle can have associated with it an optional
	///  scalar value. So the format is: x, y, z, scalar
	///  (all floats or doubles). The text file can consist of a comma
	///  delimited set of values. In most cases vtkParticleReader can
	///  automatically determine whether the file is text or binary.
	///  The data can be either float or double.
	///  Progress updates are provided.
	///  With respect to binary files, random access into the file to read
	///  pieces is supported.
	///
	/// </remarks>
	// Token: 0x0200020D RID: 525
	public class vtkParticleReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600644A RID: 25674 RVA: 0x000906C3 File Offset: 0x0008E8C3
		static vtkParticleReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkParticleReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600644B RID: 25675 RVA: 0x000906EB File Offset: 0x0008E8EB
		public vtkParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600644C RID: 25676
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600644D RID: 25677 RVA: 0x000906FC File Offset: 0x0008E8FC
		public new static vtkParticleReader New()
		{
			vtkParticleReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600644E RID: 25678 RVA: 0x00090750 File Offset: 0x0008E950
		public vtkParticleReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkParticleReader.vtkParticleReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600644F RID: 25679 RVA: 0x00090794 File Offset: 0x0008E994
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006450 RID: 25680
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetDataByteOrder_01(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006451 RID: 25681 RVA: 0x000907A0 File Offset: 0x0008E9A0
		public int GetDataByteOrder()
		{
			return vtkParticleReader.vtkParticleReader_GetDataByteOrder_01(base.GetCppThis());
		}

		// Token: 0x06006452 RID: 25682
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleReader_GetDataByteOrderAsString_02(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006453 RID: 25683 RVA: 0x000907C0 File Offset: 0x0008E9C0
		public string GetDataByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkParticleReader.vtkParticleReader_GetDataByteOrderAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006454 RID: 25684
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetDataType_03(HandleRef pThis);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x06006455 RID: 25685 RVA: 0x000907FC File Offset: 0x0008E9FC
		public virtual int GetDataType()
		{
			return vtkParticleReader.vtkParticleReader_GetDataType_03(base.GetCppThis());
		}

		// Token: 0x06006456 RID: 25686
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetDataTypeMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x06006457 RID: 25687 RVA: 0x0009081C File Offset: 0x0008EA1C
		public virtual int GetDataTypeMaxValue()
		{
			return vtkParticleReader.vtkParticleReader_GetDataTypeMaxValue_04(base.GetCppThis());
		}

		// Token: 0x06006458 RID: 25688
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetDataTypeMinValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x06006459 RID: 25689 RVA: 0x0009083C File Offset: 0x0008EA3C
		public virtual int GetDataTypeMinValue()
		{
			return vtkParticleReader.vtkParticleReader_GetDataTypeMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600645A RID: 25690
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleReader_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// Specify file name.
		/// </summary>
		// Token: 0x0600645B RID: 25691 RVA: 0x0009085C File Offset: 0x0008EA5C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkParticleReader.vtkParticleReader_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600645C RID: 25692
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetFileType_07(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x0600645D RID: 25693 RVA: 0x00090898 File Offset: 0x0008EA98
		public virtual int GetFileType()
		{
			return vtkParticleReader.vtkParticleReader_GetFileType_07(base.GetCppThis());
		}

		// Token: 0x0600645E RID: 25694
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetFileTypeMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x0600645F RID: 25695 RVA: 0x000908B8 File Offset: 0x0008EAB8
		public virtual int GetFileTypeMaxValue()
		{
			return vtkParticleReader.vtkParticleReader_GetFileTypeMaxValue_08(base.GetCppThis());
		}

		// Token: 0x06006460 RID: 25696
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetFileTypeMinValue_09(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x06006461 RID: 25697 RVA: 0x000908D8 File Offset: 0x0008EAD8
		public virtual int GetFileTypeMinValue()
		{
			return vtkParticleReader.vtkParticleReader_GetFileTypeMinValue_09(base.GetCppThis());
		}

		// Token: 0x06006462 RID: 25698
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetHasScalar_10(HandleRef pThis);

		/// <summary>
		/// Default: 1. If 1 then each particle has a value associated with it.
		/// </summary>
		// Token: 0x06006463 RID: 25699 RVA: 0x000908F8 File Offset: 0x0008EAF8
		public virtual int GetHasScalar()
		{
			return vtkParticleReader.vtkParticleReader_GetHasScalar_10(base.GetCppThis());
		}

		// Token: 0x06006464 RID: 25700
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006465 RID: 25701 RVA: 0x00090918 File Offset: 0x0008EB18
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkParticleReader.vtkParticleReader_GetNumberOfGenerationsFromBase_11(base.GetCppThis(), type);
		}

		// Token: 0x06006466 RID: 25702
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkParticleReader_GetNumberOfGenerationsFromBaseType_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006467 RID: 25703 RVA: 0x00090938 File Offset: 0x0008EB38
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkParticleReader.vtkParticleReader_GetNumberOfGenerationsFromBaseType_12(type);
		}

		// Token: 0x06006468 RID: 25704
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_GetSwapBytes_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// Not used when reading text files.
		/// </summary>
		// Token: 0x06006469 RID: 25705 RVA: 0x00090954 File Offset: 0x0008EB54
		public int GetSwapBytes()
		{
			return vtkParticleReader.vtkParticleReader_GetSwapBytes_13(base.GetCppThis());
		}

		// Token: 0x0600646A RID: 25706
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_HasScalarOff_14(HandleRef pThis);

		/// <summary>
		/// Default: 1. If 1 then each particle has a value associated with it.
		/// </summary>
		// Token: 0x0600646B RID: 25707 RVA: 0x00090973 File Offset: 0x0008EB73
		public virtual void HasScalarOff()
		{
			vtkParticleReader.vtkParticleReader_HasScalarOff_14(base.GetCppThis());
		}

		// Token: 0x0600646C RID: 25708
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_HasScalarOn_15(HandleRef pThis);

		/// <summary>
		/// Default: 1. If 1 then each particle has a value associated with it.
		/// </summary>
		// Token: 0x0600646D RID: 25709 RVA: 0x00090982 File Offset: 0x0008EB82
		public virtual void HasScalarOn()
		{
			vtkParticleReader.vtkParticleReader_HasScalarOn_15(base.GetCppThis());
		}

		// Token: 0x0600646E RID: 25710
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_IsA_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600646F RID: 25711 RVA: 0x00090994 File Offset: 0x0008EB94
		public override int IsA(string type)
		{
			return vtkParticleReader.vtkParticleReader_IsA_16(base.GetCppThis(), type);
		}

		// Token: 0x06006470 RID: 25712
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkParticleReader_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006471 RID: 25713 RVA: 0x000909B4 File Offset: 0x0008EBB4
		public new static int IsTypeOf(string type)
		{
			return vtkParticleReader.vtkParticleReader_IsTypeOf_17(type);
		}

		// Token: 0x06006472 RID: 25714
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006473 RID: 25715 RVA: 0x000909D0 File Offset: 0x0008EBD0
		public new vtkParticleReader NewInstance()
		{
			vtkParticleReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_NewInstance_19(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006474 RID: 25716
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkParticleReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006475 RID: 25717 RVA: 0x00090A2C File Offset: 0x0008EC2C
		public new static vtkParticleReader SafeDownCast(vtkObjectBase o)
		{
			vtkParticleReader vtkParticleReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkParticleReader.vtkParticleReader_SafeDownCast_20((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkParticleReader = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkParticleReader.Register(null);
				}
			}
			return vtkParticleReader;
		}

		// Token: 0x06006476 RID: 25718
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataByteOrder_21(HandleRef pThis, int arg0);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006477 RID: 25719 RVA: 0x00090AAB File Offset: 0x0008ECAB
		public void SetDataByteOrder(int arg0)
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrder_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06006478 RID: 25720
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataByteOrderToBigEndian_22(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x06006479 RID: 25721 RVA: 0x00090ABB File Offset: 0x0008ECBB
		public void SetDataByteOrderToBigEndian()
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrderToBigEndian_22(base.GetCppThis());
		}

		// Token: 0x0600647A RID: 25722
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataByteOrderToLittleEndian_23(HandleRef pThis);

		/// <summary>
		/// These methods should be used instead of the SwapBytes methods.
		/// They indicate the byte ordering of the file you are trying
		/// to read in. These methods will then either swap or not swap
		/// the bytes depending on the byte ordering of the machine it is
		/// being run on. For example, reading in a BigEndian file on a
		/// BigEndian machine will result in no swapping. Trying to read
		/// the same file on a LittleEndian machine will result in swapping.
		/// As a quick note most UNIX machines are BigEndian while PC's
		/// and VAX tend to be LittleEndian. So if the file you are reading
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
		/// otherwise SetDataByteOrderToBigEndian. Not used when reading
		/// text files.
		/// </summary>
		// Token: 0x0600647B RID: 25723 RVA: 0x00090ACA File Offset: 0x0008ECCA
		public void SetDataByteOrderToLittleEndian()
		{
			vtkParticleReader.vtkParticleReader_SetDataByteOrderToLittleEndian_23(base.GetCppThis());
		}

		// Token: 0x0600647C RID: 25724
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataType_24(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x0600647D RID: 25725 RVA: 0x00090AD9 File Offset: 0x0008ECD9
		public virtual void SetDataType(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetDataType_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600647E RID: 25726
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataTypeToDouble_25(HandleRef pThis);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x0600647F RID: 25727 RVA: 0x00090AE9 File Offset: 0x0008ECE9
		public void SetDataTypeToDouble()
		{
			vtkParticleReader.vtkParticleReader_SetDataTypeToDouble_25(base.GetCppThis());
		}

		// Token: 0x06006480 RID: 25728
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetDataTypeToFloat_26(HandleRef pThis);

		/// <summary>
		/// Get/Set the data type.  The options are:
		/// - VTK_FLOAT (default) single precision floating point.
		/// - VTK_DOUBLE double precision floating point.
		/// </summary>
		// Token: 0x06006481 RID: 25729 RVA: 0x00090AF8 File Offset: 0x0008ECF8
		public void SetDataTypeToFloat()
		{
			vtkParticleReader.vtkParticleReader_SetDataTypeToFloat_26(base.GetCppThis());
		}

		// Token: 0x06006482 RID: 25730
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetFileName_27(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name.
		/// </summary>
		// Token: 0x06006483 RID: 25731 RVA: 0x00090B07 File Offset: 0x0008ED07
		public virtual void SetFileName(string _arg)
		{
			vtkParticleReader.vtkParticleReader_SetFileName_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06006484 RID: 25732
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetFileType_28(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x06006485 RID: 25733 RVA: 0x00090B17 File Offset: 0x0008ED17
		public virtual void SetFileType(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetFileType_28(base.GetCppThis(), _arg);
		}

		// Token: 0x06006486 RID: 25734
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetFileTypeToBinary_29(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x06006487 RID: 25735 RVA: 0x00090B27 File Offset: 0x0008ED27
		public void SetFileTypeToBinary()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToBinary_29(base.GetCppThis());
		}

		// Token: 0x06006488 RID: 25736
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetFileTypeToText_30(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x06006489 RID: 25737 RVA: 0x00090B36 File Offset: 0x0008ED36
		public void SetFileTypeToText()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToText_30(base.GetCppThis());
		}

		// Token: 0x0600648A RID: 25738
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetFileTypeToUnknown_31(HandleRef pThis);

		/// <summary>
		/// Get/Set the file type.  The options are:
		/// - FILE_TYPE_IS_UNKNOWN (default) the class
		/// will attempt to determine the file type.
		/// If this fails then you should set the file type
		/// yourself.
		/// - FILE_TYPE_IS_TEXT the file type is text.
		/// - FILE_TYPE_IS_BINARY the file type is binary.
		/// </summary>
		// Token: 0x0600648B RID: 25739 RVA: 0x00090B45 File Offset: 0x0008ED45
		public void SetFileTypeToUnknown()
		{
			vtkParticleReader.vtkParticleReader_SetFileTypeToUnknown_31(base.GetCppThis());
		}

		// Token: 0x0600648C RID: 25740
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetHasScalar_32(HandleRef pThis, int _arg);

		/// <summary>
		/// Default: 1. If 1 then each particle has a value associated with it.
		/// </summary>
		// Token: 0x0600648D RID: 25741 RVA: 0x00090B54 File Offset: 0x0008ED54
		public virtual void SetHasScalar(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetHasScalar_32(base.GetCppThis(), _arg);
		}

		// Token: 0x0600648E RID: 25742
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SetSwapBytes_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// Not used when reading text files.
		/// </summary>
		// Token: 0x0600648F RID: 25743 RVA: 0x00090B64 File Offset: 0x0008ED64
		public virtual void SetSwapBytes(int _arg)
		{
			vtkParticleReader.vtkParticleReader_SetSwapBytes_33(base.GetCppThis(), _arg);
		}

		// Token: 0x06006490 RID: 25744
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SwapBytesOff_34(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// Not used when reading text files.
		/// </summary>
		// Token: 0x06006491 RID: 25745 RVA: 0x00090B74 File Offset: 0x0008ED74
		public virtual void SwapBytesOff()
		{
			vtkParticleReader.vtkParticleReader_SwapBytesOff_34(base.GetCppThis());
		}

		// Token: 0x06006492 RID: 25746
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkParticleReader_SwapBytesOn_35(HandleRef pThis);

		/// <summary>
		/// Set/Get the byte swapping to explicitly swap the bytes of a file.
		/// Not used when reading text files.
		/// </summary>
		// Token: 0x06006493 RID: 25747 RVA: 0x00090B83 File Offset: 0x0008ED83
		public virtual void SwapBytesOn()
		{
			vtkParticleReader.vtkParticleReader_SwapBytesOn_35(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008F1 RID: 2289
		public new const string MRFullTypeName = "Kitware.VTK.vtkParticleReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008F2 RID: 2290
		public new static readonly string MRClassNameKey = "class vtkParticleReader";
	}
}
