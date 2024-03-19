using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMCubesReader
	/// </summary>
	/// <remarks>
	///    read binary marching cubes file
	///
	/// vtkMCubesReader is a source object that reads binary marching cubes
	/// files. (Marching cubes is an isosurfacing technique that generates
	/// many triangles.) The binary format is supported by W. Lorensen's
	/// marching cubes program (and the vtkSliceCubes object). The format
	/// repeats point coordinates, so this object will merge the points
	/// with a vtkLocator object. You can choose to supply the vtkLocator
	/// or use the default.
	///
	/// @warning
	/// Binary files assumed written in sun/hp/sgi (i.e., Big Endian) form.
	///
	/// @warning
	/// Because points are merged when read, degenerate triangles may be removed.
	/// Thus the number of triangles read may be fewer than the number of triangles
	/// actually created.
	///
	/// @warning
	/// The point merging does not take into account that the same point may have
	/// different normals. For example, running vtkPolyDataNormals after
	/// vtkContourFilter may split triangles because of the FeatureAngle
	/// ivar. Subsequent reading with vtkMCubesReader will merge the points and
	/// use the first point's normal. For the most part, this is undesirable.
	///
	/// @warning
	/// Normals are generated from the gradient of the data scalar values. Hence
	/// the normals may on occasion point in a direction inconsistent with the
	/// ordering of the triangle vertices. If this happens, the resulting surface
	/// may be "black".  Reverse the sense of the FlipNormals boolean flag to
	/// correct this.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkMarchingCubes vtkSliceCubes vtkLocator
	/// </seealso>
	// Token: 0x02000208 RID: 520
	public class vtkMCubesReader : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600636E RID: 25454 RVA: 0x0008F207 File Offset: 0x0008D407
		static vtkMCubesReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMCubesReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMCubesReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600636F RID: 25455 RVA: 0x0008F22F File Offset: 0x0008D42F
		public vtkMCubesReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006370 RID: 25456
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06006371 RID: 25457 RVA: 0x0008F240 File Offset: 0x0008D440
		public new static vtkMCubesReader New()
		{
			vtkMCubesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with FlipNormals turned off and Normals set to true.
		/// </summary>
		// Token: 0x06006372 RID: 25458 RVA: 0x0008F294 File Offset: 0x0008D494
		public vtkMCubesReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMCubesReader.vtkMCubesReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006373 RID: 25459 RVA: 0x0008F2D8 File Offset: 0x0008D4D8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006374 RID: 25460
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_CreateDefaultLocator_01(HandleRef pThis);

		/// <summary>
		/// Create default locator. Used to create one when none is specified.
		/// </summary>
		// Token: 0x06006375 RID: 25461 RVA: 0x0008F2E3 File Offset: 0x0008D4E3
		public void CreateDefaultLocator()
		{
			vtkMCubesReader.vtkMCubesReader_CreateDefaultLocator_01(base.GetCppThis());
		}

		// Token: 0x06006376 RID: 25462
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_FlipNormalsOff_02(HandleRef pThis);

		/// <summary>
		/// Specify whether to flip normals in opposite direction. Flipping ONLY
		/// changes the direction of the normal vector. Contrast this with flipping
		/// in vtkPolyDataNormals which flips both the normal and the cell point
		/// order.
		/// </summary>
		// Token: 0x06006377 RID: 25463 RVA: 0x0008F2F2 File Offset: 0x0008D4F2
		public virtual void FlipNormalsOff()
		{
			vtkMCubesReader.vtkMCubesReader_FlipNormalsOff_02(base.GetCppThis());
		}

		// Token: 0x06006378 RID: 25464
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_FlipNormalsOn_03(HandleRef pThis);

		/// <summary>
		/// Specify whether to flip normals in opposite direction. Flipping ONLY
		/// changes the direction of the normal vector. Contrast this with flipping
		/// in vtkPolyDataNormals which flips both the normal and the cell point
		/// order.
		/// </summary>
		// Token: 0x06006379 RID: 25465 RVA: 0x0008F301 File Offset: 0x0008D501
		public virtual void FlipNormalsOn()
		{
			vtkMCubesReader.vtkMCubesReader_FlipNormalsOn_03(base.GetCppThis());
		}

		// Token: 0x0600637A RID: 25466
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetDataByteOrder_04(HandleRef pThis);

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
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0600637B RID: 25467 RVA: 0x0008F310 File Offset: 0x0008D510
		public int GetDataByteOrder()
		{
			return vtkMCubesReader.vtkMCubesReader_GetDataByteOrder_04(base.GetCppThis());
		}

		// Token: 0x0600637C RID: 25468
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_GetDataByteOrderAsString_05(HandleRef pThis);

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
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x0600637D RID: 25469 RVA: 0x0008F330 File Offset: 0x0008D530
		public string GetDataByteOrderAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetDataByteOrderAsString_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600637E RID: 25470
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_GetFileName_06(HandleRef pThis);

		/// <summary>
		/// Specify file name of marching cubes file.
		/// </summary>
		// Token: 0x0600637F RID: 25471 RVA: 0x0008F36C File Offset: 0x0008D56C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetFileName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006380 RID: 25472
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetFlipNormals_07(HandleRef pThis);

		/// <summary>
		/// Specify whether to flip normals in opposite direction. Flipping ONLY
		/// changes the direction of the normal vector. Contrast this with flipping
		/// in vtkPolyDataNormals which flips both the normal and the cell point
		/// order.
		/// </summary>
		// Token: 0x06006381 RID: 25473 RVA: 0x0008F3A8 File Offset: 0x0008D5A8
		public virtual int GetFlipNormals()
		{
			return vtkMCubesReader.vtkMCubesReader_GetFlipNormals_07(base.GetCppThis());
		}

		// Token: 0x06006382 RID: 25474
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetHeaderSize_08(HandleRef pThis);

		/// <summary>
		/// Specify a header size if one exists. The header is skipped and not used at this time.
		/// </summary>
		// Token: 0x06006383 RID: 25475 RVA: 0x0008F3C8 File Offset: 0x0008D5C8
		public virtual int GetHeaderSize()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSize_08(base.GetCppThis());
		}

		// Token: 0x06006384 RID: 25476
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetHeaderSizeMaxValue_09(HandleRef pThis);

		/// <summary>
		/// Specify a header size if one exists. The header is skipped and not used at this time.
		/// </summary>
		// Token: 0x06006385 RID: 25477 RVA: 0x0008F3E8 File Offset: 0x0008D5E8
		public virtual int GetHeaderSizeMaxValue()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSizeMaxValue_09(base.GetCppThis());
		}

		// Token: 0x06006386 RID: 25478
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetHeaderSizeMinValue_10(HandleRef pThis);

		/// <summary>
		/// Specify a header size if one exists. The header is skipped and not used at this time.
		/// </summary>
		// Token: 0x06006387 RID: 25479 RVA: 0x0008F408 File Offset: 0x0008D608
		public virtual int GetHeaderSizeMinValue()
		{
			return vtkMCubesReader.vtkMCubesReader_GetHeaderSizeMinValue_10(base.GetCppThis());
		}

		// Token: 0x06006388 RID: 25480
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_GetLimitsFileName_11(HandleRef pThis);

		/// <summary>
		/// Set / get the file name of the marching cubes limits file.
		/// </summary>
		// Token: 0x06006389 RID: 25481 RVA: 0x0008F428 File Offset: 0x0008D628
		public virtual string GetLimitsFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMCubesReader.vtkMCubesReader_GetLimitsFileName_11(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600638A RID: 25482
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_GetLocator_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x0600638B RID: 25483 RVA: 0x0008F464 File Offset: 0x0008D664
		public virtual vtkIncrementalPointLocator GetLocator()
		{
			vtkIncrementalPointLocator vtkIncrementalPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_GetLocator_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600638C RID: 25484
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkMCubesReader_GetMTime_13(HandleRef pThis);

		/// <summary>
		/// Return the mtime also considering the locator.
		/// </summary>
		// Token: 0x0600638D RID: 25485 RVA: 0x0008F4D4 File Offset: 0x0008D6D4
		public override ulong GetMTime()
		{
			return vtkMCubesReader.vtkMCubesReader_GetMTime_13(base.GetCppThis());
		}

		// Token: 0x0600638E RID: 25486
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetNormals_14(HandleRef pThis);

		/// <summary>
		/// Specify whether to read normals.
		/// </summary>
		// Token: 0x0600638F RID: 25487 RVA: 0x0008F4F4 File Offset: 0x0008D6F4
		public virtual int GetNormals()
		{
			return vtkMCubesReader.vtkMCubesReader_GetNormals_14(base.GetCppThis());
		}

		// Token: 0x06006390 RID: 25488
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMCubesReader_GetNumberOfGenerationsFromBase_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006391 RID: 25489 RVA: 0x0008F514 File Offset: 0x0008D714
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_GetNumberOfGenerationsFromBase_15(base.GetCppThis(), type);
		}

		// Token: 0x06006392 RID: 25490
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMCubesReader_GetNumberOfGenerationsFromBaseType_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006393 RID: 25491 RVA: 0x0008F534 File Offset: 0x0008D734
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_GetNumberOfGenerationsFromBaseType_16(type);
		}

		// Token: 0x06006394 RID: 25492
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_GetSwapBytes_17(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x06006395 RID: 25493 RVA: 0x0008F550 File Offset: 0x0008D750
		public virtual int GetSwapBytes()
		{
			return vtkMCubesReader.vtkMCubesReader_GetSwapBytes_17(base.GetCppThis());
		}

		// Token: 0x06006396 RID: 25494
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_IsA_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006397 RID: 25495 RVA: 0x0008F570 File Offset: 0x0008D770
		public override int IsA(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_IsA_18(base.GetCppThis(), type);
		}

		// Token: 0x06006398 RID: 25496
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMCubesReader_IsTypeOf_19([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006399 RID: 25497 RVA: 0x0008F590 File Offset: 0x0008D790
		public new static int IsTypeOf(string type)
		{
			return vtkMCubesReader.vtkMCubesReader_IsTypeOf_19(type);
		}

		// Token: 0x0600639A RID: 25498
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600639B RID: 25499 RVA: 0x0008F5AC File Offset: 0x0008D7AC
		public new vtkMCubesReader NewInstance()
		{
			vtkMCubesReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_NewInstance_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600639C RID: 25500
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_NormalsOff_22(HandleRef pThis);

		/// <summary>
		/// Specify whether to read normals.
		/// </summary>
		// Token: 0x0600639D RID: 25501 RVA: 0x0008F606 File Offset: 0x0008D806
		public virtual void NormalsOff()
		{
			vtkMCubesReader.vtkMCubesReader_NormalsOff_22(base.GetCppThis());
		}

		// Token: 0x0600639E RID: 25502
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_NormalsOn_23(HandleRef pThis);

		/// <summary>
		/// Specify whether to read normals.
		/// </summary>
		// Token: 0x0600639F RID: 25503 RVA: 0x0008F615 File Offset: 0x0008D815
		public virtual void NormalsOn()
		{
			vtkMCubesReader.vtkMCubesReader_NormalsOn_23(base.GetCppThis());
		}

		// Token: 0x060063A0 RID: 25504
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMCubesReader_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060063A1 RID: 25505 RVA: 0x0008F624 File Offset: 0x0008D824
		public new static vtkMCubesReader SafeDownCast(vtkObjectBase o)
		{
			vtkMCubesReader vtkMCubesReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMCubesReader.vtkMCubesReader_SafeDownCast_24((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMCubesReader = (vtkMCubesReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMCubesReader.Register(null);
				}
			}
			return vtkMCubesReader;
		}

		// Token: 0x060063A2 RID: 25506
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetDataByteOrder_25(HandleRef pThis, int arg0);

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
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x060063A3 RID: 25507 RVA: 0x0008F6A3 File Offset: 0x0008D8A3
		public void SetDataByteOrder(int arg0)
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrder_25(base.GetCppThis(), arg0);
		}

		// Token: 0x060063A4 RID: 25508
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetDataByteOrderToBigEndian_26(HandleRef pThis);

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
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x060063A5 RID: 25509 RVA: 0x0008F6B3 File Offset: 0x0008D8B3
		public void SetDataByteOrderToBigEndian()
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrderToBigEndian_26(base.GetCppThis());
		}

		// Token: 0x060063A6 RID: 25510
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetDataByteOrderToLittleEndian_27(HandleRef pThis);

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
		/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
		/// SetDataByteOrderToBigEndian.
		/// </summary>
		// Token: 0x060063A7 RID: 25511 RVA: 0x0008F6C2 File Offset: 0x0008D8C2
		public void SetDataByteOrderToLittleEndian()
		{
			vtkMCubesReader.vtkMCubesReader_SetDataByteOrderToLittleEndian_27(base.GetCppThis());
		}

		// Token: 0x060063A8 RID: 25512
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetFileName_28(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name of marching cubes file.
		/// </summary>
		// Token: 0x060063A9 RID: 25513 RVA: 0x0008F6D1 File Offset: 0x0008D8D1
		public virtual void SetFileName(string _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetFileName_28(base.GetCppThis(), _arg);
		}

		// Token: 0x060063AA RID: 25514
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetFlipNormals_29(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to flip normals in opposite direction. Flipping ONLY
		/// changes the direction of the normal vector. Contrast this with flipping
		/// in vtkPolyDataNormals which flips both the normal and the cell point
		/// order.
		/// </summary>
		// Token: 0x060063AB RID: 25515 RVA: 0x0008F6E1 File Offset: 0x0008D8E1
		public virtual void SetFlipNormals(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetFlipNormals_29(base.GetCppThis(), _arg);
		}

		// Token: 0x060063AC RID: 25516
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetHeaderSize_30(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify a header size if one exists. The header is skipped and not used at this time.
		/// </summary>
		// Token: 0x060063AD RID: 25517 RVA: 0x0008F6F1 File Offset: 0x0008D8F1
		public virtual void SetHeaderSize(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetHeaderSize_30(base.GetCppThis(), _arg);
		}

		// Token: 0x060063AE RID: 25518
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetLimitsFileName_31(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set / get the file name of the marching cubes limits file.
		/// </summary>
		// Token: 0x060063AF RID: 25519 RVA: 0x0008F701 File Offset: 0x0008D901
		public virtual void SetLimitsFileName(string _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetLimitsFileName_31(base.GetCppThis(), _arg);
		}

		// Token: 0x060063B0 RID: 25520
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetLocator_32(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Set / get a spatial locator for merging points. By default,
		/// an instance of vtkMergePoints is used.
		/// </summary>
		// Token: 0x060063B1 RID: 25521 RVA: 0x0008F714 File Offset: 0x0008D914
		public void SetLocator(vtkIncrementalPointLocator locator)
		{
			vtkMCubesReader.vtkMCubesReader_SetLocator_32(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x060063B2 RID: 25522
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetNormals_33(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to read normals.
		/// </summary>
		// Token: 0x060063B3 RID: 25523 RVA: 0x0008F743 File Offset: 0x0008D943
		public virtual void SetNormals(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetNormals_33(base.GetCppThis(), _arg);
		}

		// Token: 0x060063B4 RID: 25524
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SetSwapBytes_34(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x060063B5 RID: 25525 RVA: 0x0008F753 File Offset: 0x0008D953
		public virtual void SetSwapBytes(int _arg)
		{
			vtkMCubesReader.vtkMCubesReader_SetSwapBytes_34(base.GetCppThis(), _arg);
		}

		// Token: 0x060063B6 RID: 25526
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SwapBytesOff_35(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x060063B7 RID: 25527 RVA: 0x0008F763 File Offset: 0x0008D963
		public virtual void SwapBytesOff()
		{
			vtkMCubesReader.vtkMCubesReader_SwapBytesOff_35(base.GetCppThis());
		}

		// Token: 0x060063B8 RID: 25528
		[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMCubesReader_SwapBytesOn_36(HandleRef pThis);

		/// <summary>
		/// Turn on/off byte swapping.
		/// </summary>
		// Token: 0x060063B9 RID: 25529 RVA: 0x0008F772 File Offset: 0x0008D972
		public virtual void SwapBytesOn()
		{
			vtkMCubesReader.vtkMCubesReader_SwapBytesOn_36(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E7 RID: 2279
		public new const string MRFullTypeName = "Kitware.VTK.vtkMCubesReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040008E8 RID: 2280
		public new static readonly string MRClassNameKey = "class vtkMCubesReader";
	}
}
