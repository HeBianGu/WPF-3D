using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageRectilinearWipe
	/// </summary>
	/// <remarks>
	///    make a rectilinear combination of two images.
	///
	/// vtkImageRectilinearWipe makes a rectilinear combination of two
	/// images. The two input images must correspond in size, scalar type and
	/// number of components.
	/// The resulting image has four possible configurations
	/// called:
	///   Quad - alternate input 0 and input 1 horizontally and
	///     vertically. Select this with SetWipeModeToQuad. The Position
	///     specifies the location of the quad intersection.
	///   Corner - 3 of one input and 1 of the other. Select the location of
	///     input 0 with with SetWipeModeToLowerLeft, SetWipeModeToLowerRight,
	///     SetWipeModeToUpperLeft and SetWipeModeToUpperRight. The Position
	///     selects the location of the corner.
	///   Horizontal - alternate input 0 and input 1 with a vertical
	///     split. Select this with SetWipeModeToHorizontal. Position[0]
	///     specifies the location of the vertical transition between input 0
	///     and input 1.
	///   Vertical - alternate input 0 and input 1 with a horizontal
	///     split. Only the y The intersection point of the rectilinear points
	///     is controlled with the Point ivar.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageCheckerboard
	/// </seealso>
	// Token: 0x020003E4 RID: 996
	public class vtkImageRectilinearWipe : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BED3 RID: 48851 RVA: 0x00109FD5 File Offset: 0x001081D5
		static vtkImageRectilinearWipe()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageRectilinearWipe.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageRectilinearWipe"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BED4 RID: 48852 RVA: 0x00109FFD File Offset: 0x001081FD
		public vtkImageRectilinearWipe(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BED5 RID: 48853
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRectilinearWipe_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BED6 RID: 48854 RVA: 0x0010A00C File Offset: 0x0010820C
		public new static vtkImageRectilinearWipe New()
		{
			vtkImageRectilinearWipe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BED7 RID: 48855 RVA: 0x0010A060 File Offset: 0x00108260
		public vtkImageRectilinearWipe() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageRectilinearWipe.vtkImageRectilinearWipe_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BED8 RID: 48856 RVA: 0x0010A0A4 File Offset: 0x001082A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BED9 RID: 48857
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRectilinearWipe_GetAxis_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
		/// values of 0 and 1).
		/// </summary>
		// Token: 0x0600BEDA RID: 48858 RVA: 0x0010A0B0 File Offset: 0x001082B0
		public virtual int[] GetAxis()
		{
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetAxis_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BEDB RID: 48859
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_GetAxis_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
		/// values of 0 and 1).
		/// </summary>
		// Token: 0x0600BEDC RID: 48860 RVA: 0x0010A0F8 File Offset: 0x001082F8
		public virtual void GetAxis(IntPtr data)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetAxis_02(base.GetCppThis(), data);
		}

		// Token: 0x0600BEDD RID: 48861
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRectilinearWipe_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEDE RID: 48862 RVA: 0x0010A108 File Offset: 0x00108308
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0600BEDF RID: 48863
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageRectilinearWipe_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEE0 RID: 48864 RVA: 0x0010A128 File Offset: 0x00108328
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0600BEE1 RID: 48865
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRectilinearWipe_GetPosition_05(HandleRef pThis);

		/// <summary>
		/// Set/Get the location of the image transition. Note that position is
		/// specified in pixels.
		/// </summary>
		// Token: 0x0600BEE2 RID: 48866 RVA: 0x0010A144 File Offset: 0x00108344
		public virtual int[] GetPosition()
		{
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetPosition_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600BEE3 RID: 48867
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_GetPosition_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set/Get the location of the image transition. Note that position is
		/// specified in pixels.
		/// </summary>
		// Token: 0x0600BEE4 RID: 48868 RVA: 0x0010A18C File Offset: 0x0010838C
		public virtual void GetPosition(IntPtr data)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetPosition_06(base.GetCppThis(), data);
		}

		// Token: 0x0600BEE5 RID: 48869
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRectilinearWipe_GetWipe_07(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BEE6 RID: 48870 RVA: 0x0010A19C File Offset: 0x0010839C
		public virtual int GetWipe()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipe_07(base.GetCppThis());
		}

		// Token: 0x0600BEE7 RID: 48871
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRectilinearWipe_GetWipeMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BEE8 RID: 48872 RVA: 0x0010A1BC File Offset: 0x001083BC
		public virtual int GetWipeMaxValue()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipeMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600BEE9 RID: 48873
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRectilinearWipe_GetWipeMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BEEA RID: 48874 RVA: 0x0010A1DC File Offset: 0x001083DC
		public virtual int GetWipeMinValue()
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_GetWipeMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600BEEB RID: 48875
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRectilinearWipe_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEEC RID: 48876 RVA: 0x0010A1FC File Offset: 0x001083FC
		public override int IsA(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600BEED RID: 48877
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageRectilinearWipe_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEEE RID: 48878 RVA: 0x0010A21C File Offset: 0x0010841C
		public new static int IsTypeOf(string type)
		{
			return vtkImageRectilinearWipe.vtkImageRectilinearWipe_IsTypeOf_11(type);
		}

		// Token: 0x0600BEEF RID: 48879
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRectilinearWipe_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEF0 RID: 48880 RVA: 0x0010A238 File Offset: 0x00108438
		public new vtkImageRectilinearWipe NewInstance()
		{
			vtkImageRectilinearWipe result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BEF1 RID: 48881
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageRectilinearWipe_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BEF2 RID: 48882 RVA: 0x0010A294 File Offset: 0x00108494
		public new static vtkImageRectilinearWipe SafeDownCast(vtkObjectBase o)
		{
			vtkImageRectilinearWipe vtkImageRectilinearWipe = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageRectilinearWipe.vtkImageRectilinearWipe_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageRectilinearWipe = (vtkImageRectilinearWipe)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageRectilinearWipe.Register(null);
				}
			}
			return vtkImageRectilinearWipe;
		}

		// Token: 0x0600BEF3 RID: 48883
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetAxis_15(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
		/// values of 0 and 1).
		/// </summary>
		// Token: 0x0600BEF4 RID: 48884 RVA: 0x0010A313 File Offset: 0x00108513
		public virtual void SetAxis(int _arg1, int _arg2)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetAxis_15(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BEF5 RID: 48885
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetAxis_16(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the location of the wipe axes. The default is X,Y (ie vector
		/// values of 0 and 1).
		/// </summary>
		// Token: 0x0600BEF6 RID: 48886 RVA: 0x0010A324 File Offset: 0x00108524
		public void SetAxis(IntPtr _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetAxis_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BEF7 RID: 48887
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetInput1Data_17(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter.
		/// </summary>
		// Token: 0x0600BEF8 RID: 48888 RVA: 0x0010A334 File Offset: 0x00108534
		public virtual void SetInput1Data(vtkDataObject arg0)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetInput1Data_17(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BEF9 RID: 48889
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetInput2Data_18(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the two inputs to this filter.
		/// </summary>
		// Token: 0x0600BEFA RID: 48890 RVA: 0x0010A364 File Offset: 0x00108564
		public virtual void SetInput2Data(vtkDataObject arg0)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetInput2Data_18(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600BEFB RID: 48891
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetPosition_19(HandleRef pThis, int _arg1, int _arg2);

		/// <summary>
		/// Set/Get the location of the image transition. Note that position is
		/// specified in pixels.
		/// </summary>
		// Token: 0x0600BEFC RID: 48892 RVA: 0x0010A393 File Offset: 0x00108593
		public virtual void SetPosition(int _arg1, int _arg2)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetPosition_19(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0600BEFD RID: 48893
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetPosition_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the location of the image transition. Note that position is
		/// specified in pixels.
		/// </summary>
		// Token: 0x0600BEFE RID: 48894 RVA: 0x0010A3A4 File Offset: 0x001085A4
		public void SetPosition(IntPtr _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetPosition_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BEFF RID: 48895
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipe_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF00 RID: 48896 RVA: 0x0010A3B4 File Offset: 0x001085B4
		public virtual void SetWipe(int _arg)
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipe_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF01 RID: 48897
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToHorizontal_22(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF02 RID: 48898 RVA: 0x0010A3C4 File Offset: 0x001085C4
		public void SetWipeToHorizontal()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToHorizontal_22(base.GetCppThis());
		}

		// Token: 0x0600BF03 RID: 48899
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToLowerLeft_23(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF04 RID: 48900 RVA: 0x0010A3D3 File Offset: 0x001085D3
		public void SetWipeToLowerLeft()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToLowerLeft_23(base.GetCppThis());
		}

		// Token: 0x0600BF05 RID: 48901
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToLowerRight_24(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF06 RID: 48902 RVA: 0x0010A3E2 File Offset: 0x001085E2
		public void SetWipeToLowerRight()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToLowerRight_24(base.GetCppThis());
		}

		// Token: 0x0600BF07 RID: 48903
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToQuad_25(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF08 RID: 48904 RVA: 0x0010A3F1 File Offset: 0x001085F1
		public void SetWipeToQuad()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToQuad_25(base.GetCppThis());
		}

		// Token: 0x0600BF09 RID: 48905
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToUpperLeft_26(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF0A RID: 48906 RVA: 0x0010A400 File Offset: 0x00108600
		public void SetWipeToUpperLeft()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToUpperLeft_26(base.GetCppThis());
		}

		// Token: 0x0600BF0B RID: 48907
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToUpperRight_27(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF0C RID: 48908 RVA: 0x0010A40F File Offset: 0x0010860F
		public void SetWipeToUpperRight()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToUpperRight_27(base.GetCppThis());
		}

		// Token: 0x0600BF0D RID: 48909
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageRectilinearWipe_SetWipeToVertical_28(HandleRef pThis);

		/// <summary>
		/// Specify the wipe mode. This mode determnis how input 0 and input
		/// 1 are combined to produce the output. Each mode uses one or both
		/// of the values stored in Position.
		/// SetWipeToQuad - alternate input 0 and input 1 horizontally and
		/// vertically. The Position specifies the location of the quad
		/// intersection.
		/// SetWipeToLowerLeft{LowerRight,UpperLeft.UpperRight} - 3 of one
		/// input and 1 of the other. Select the location of input 0 to the
		/// LowerLeft{LowerRight,UpperLeft,UpperRight}. Position
		/// selects the location of the corner.
		/// SetWipeToHorizontal - alternate input 0 and input 1 with a vertical
		/// split. Position[0] specifies the location of the vertical
		/// transition between input 0 and input 1.
		/// SetWipeToVertical - alternate input 0 and input 1 with a
		/// horizontal split. Position[1] specifies the location of the
		/// horizontal transition between input 0 and input 1.
		/// </summary>
		// Token: 0x0600BF0E RID: 48910 RVA: 0x0010A41E File Offset: 0x0010861E
		public void SetWipeToVertical()
		{
			vtkImageRectilinearWipe.vtkImageRectilinearWipe_SetWipeToVertical_28(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E35 RID: 3637
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageRectilinearWipe";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E36 RID: 3638
		public new static readonly string MRClassNameKey = "class vtkImageRectilinearWipe";
	}
}
