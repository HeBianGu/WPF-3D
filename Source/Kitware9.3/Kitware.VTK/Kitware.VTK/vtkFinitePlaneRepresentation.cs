using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFinitePlaneRepresentation
	/// </summary>
	/// <remarks>
	///    represent the vtkFinitePlaneWidget.
	///
	/// This class is a concrete representation for the vtkFinitePlaneWidget. It
	/// represents a plane with three handles: one on two faces, plus a
	/// center handle. Through interaction with the widget, the plane
	/// representation can be arbitrarily positioned and modified in the 3D space.
	///
	/// To use this representation, you normally use the PlaceWidget() method
	/// to position the widget at a specified region in space.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFinitePlaneWidget vtkImplicitPlaneWidget2
	/// </seealso>
	// Token: 0x02000317 RID: 791
	public class vtkFinitePlaneRepresentation : vtkWidgetRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008DE5 RID: 36325 RVA: 0x000CA4D7 File Offset: 0x000C86D7
		static vtkFinitePlaneRepresentation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFinitePlaneRepresentation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFinitePlaneRepresentation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008DE6 RID: 36326 RVA: 0x000CA4FF File Offset: 0x000C86FF
		public vtkFinitePlaneRepresentation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008DE7 RID: 36327
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008DE8 RID: 36328 RVA: 0x000CA510 File Offset: 0x000C8710
		public new static vtkFinitePlaneRepresentation New()
		{
			vtkFinitePlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate the class.
		/// </summary>
		// Token: 0x06008DE9 RID: 36329 RVA: 0x000CA564 File Offset: 0x000C8764
		public vtkFinitePlaneRepresentation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008DEA RID: 36330 RVA: 0x000CA5A8 File Offset: 0x000C87A8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008DEB RID: 36331
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008DEC RID: 36332 RVA: 0x000CA5B3 File Offset: 0x000C87B3
		public override void BuildRepresentation()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008DED RID: 36333
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_ComputeInteractionState_02(HandleRef pThis, int X, int Y, int modify);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008DEE RID: 36334 RVA: 0x000CA5C4 File Offset: 0x000C87C4
		public override int ComputeInteractionState(int X, int Y, int modify)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_ComputeInteractionState_02(base.GetCppThis(), X, Y, modify);
		}

		// Token: 0x06008DEF RID: 36335
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_DrawPlaneOff_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008DF0 RID: 36336 RVA: 0x000CA5E6 File Offset: 0x000C87E6
		public virtual void DrawPlaneOff()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_DrawPlaneOff_03(base.GetCppThis());
		}

		// Token: 0x06008DF1 RID: 36337
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_DrawPlaneOn_04(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008DF2 RID: 36338 RVA: 0x000CA5F5 File Offset: 0x000C87F5
		public virtual void DrawPlaneOn()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_DrawPlaneOn_04(base.GetCppThis());
		}

		// Token: 0x06008DF3 RID: 36339
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetBounds_05(HandleRef pThis);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008DF4 RID: 36340 RVA: 0x000CA604 File Offset: 0x000C8804
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetBounds_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008DF5 RID: 36341
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFinitePlaneRepresentation_GetDrawPlane_06(HandleRef pThis);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008DF6 RID: 36342 RVA: 0x000CA64C File Offset: 0x000C884C
		public virtual bool GetDrawPlane()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetDrawPlane_06(base.GetCppThis()) != 0;
		}

		// Token: 0x06008DF7 RID: 36343
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_GetInteractionStateMaxValue_07(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008DF8 RID: 36344 RVA: 0x000CA674 File Offset: 0x000C8874
		public virtual int GetInteractionStateMaxValue()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetInteractionStateMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06008DF9 RID: 36345
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_GetInteractionStateMinValue_08(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008DFA RID: 36346 RVA: 0x000CA694 File Offset: 0x000C8894
		public virtual int GetInteractionStateMinValue()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetInteractionStateMinValue_08(base.GetCppThis());
		}

		// Token: 0x06008DFB RID: 36347
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetNormal_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008DFC RID: 36348 RVA: 0x000CA6B4 File Offset: 0x000C88B4
		public virtual double[] GetNormal()
		{
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNormal_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008DFD RID: 36349
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetNormal_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008DFE RID: 36350 RVA: 0x000CA6FC File Offset: 0x000C88FC
		public virtual void GetNormal(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNormal_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008DFF RID: 36351
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetNormal_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008E00 RID: 36352 RVA: 0x000CA70E File Offset: 0x000C890E
		public virtual void GetNormal(IntPtr _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNormal_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E01 RID: 36353
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetNormalProperty_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E02 RID: 36354 RVA: 0x000CA720 File Offset: 0x000C8920
		public virtual vtkProperty GetNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNormalProperty_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E03 RID: 36355
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBase_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E04 RID: 36356 RVA: 0x000CA790 File Offset: 0x000C8990
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBase_13(base.GetCppThis(), type);
		}

		// Token: 0x06008E05 RID: 36357
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBaseType_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E06 RID: 36358 RVA: 0x000CA7B0 File Offset: 0x000C89B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetNumberOfGenerationsFromBaseType_14(type);
		}

		// Token: 0x06008E07 RID: 36359
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetOrigin_15(HandleRef pThis);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008E08 RID: 36360 RVA: 0x000CA7CC File Offset: 0x000C89CC
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetOrigin_15(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008E09 RID: 36361
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetOrigin_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008E0A RID: 36362 RVA: 0x000CA814 File Offset: 0x000C8A14
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetOrigin_16(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06008E0B RID: 36363
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetOrigin_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008E0C RID: 36364 RVA: 0x000CA826 File Offset: 0x000C8A26
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetOrigin_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E0D RID: 36365
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetPlaneProperty_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The
		/// properties of the plane when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008E0E RID: 36366 RVA: 0x000CA838 File Offset: 0x000C8A38
		public virtual vtkProperty GetPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetPlaneProperty_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E0F RID: 36367
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetPolyData_19(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Grab the polydata that defines the plane. The polydata contains a single
		/// polygon.
		/// </summary>
		// Token: 0x06008E10 RID: 36368 RVA: 0x000CA8A8 File Offset: 0x000C8AA8
		public void GetPolyData(vtkPolyData pd)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetPolyData_19(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x06008E11 RID: 36369
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_GetRepresentationState_20(HandleRef pThis);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008E12 RID: 36370 RVA: 0x000CA8D8 File Offset: 0x000C8AD8
		public virtual int GetRepresentationState()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetRepresentationState_20(base.GetCppThis());
		}

		// Token: 0x06008E13 RID: 36371
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedHandleProperty_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x06008E14 RID: 36372 RVA: 0x000CA8F8 File Offset: 0x000C8AF8
		public virtual vtkProperty GetSelectedHandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetSelectedHandleProperty_21(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E15 RID: 36373
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedNormalProperty_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E16 RID: 36374 RVA: 0x000CA968 File Offset: 0x000C8B68
		public virtual vtkProperty GetSelectedNormalProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetSelectedNormalProperty_22(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E17 RID: 36375
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetSelectedPlaneProperty_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the plane properties. The
		/// properties of the plane when selected and normal can be
		/// set.
		/// </summary>
		// Token: 0x06008E18 RID: 36376 RVA: 0x000CA9D8 File Offset: 0x000C8BD8
		public virtual vtkProperty GetSelectedPlaneProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetSelectedPlaneProperty_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E19 RID: 36377
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFinitePlaneRepresentation_GetTubing_24(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06008E1A RID: 36378 RVA: 0x000CAA48 File Offset: 0x000C8C48
		public virtual bool GetTubing()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetTubing_24(base.GetCppThis()) != 0;
		}

		// Token: 0x06008E1B RID: 36379
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetV1_25(HandleRef pThis);

		/// <summary>
		/// Set/Get the v1 vector of the plane.
		/// </summary>
		// Token: 0x06008E1C RID: 36380 RVA: 0x000CAA70 File Offset: 0x000C8C70
		public virtual double[] GetV1()
		{
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV1_25(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008E1D RID: 36381
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetV1_26(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the v1 vector of the plane.
		/// </summary>
		// Token: 0x06008E1E RID: 36382 RVA: 0x000CAAB8 File Offset: 0x000C8CB8
		public virtual void GetV1(ref double _arg1, ref double _arg2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV1_26(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06008E1F RID: 36383
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetV1_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the v1 vector of the plane.
		/// </summary>
		// Token: 0x06008E20 RID: 36384 RVA: 0x000CAAC9 File Offset: 0x000C8CC9
		public virtual void GetV1(IntPtr _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV1_27(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E21 RID: 36385
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetV1HandleProperty_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x06008E22 RID: 36386 RVA: 0x000CAADC File Offset: 0x000C8CDC
		public virtual vtkProperty GetV1HandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV1HandleProperty_28(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E23 RID: 36387
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetV2_29(HandleRef pThis);

		/// <summary>
		/// Set/Get the v2 vector of the plane.
		/// </summary>
		// Token: 0x06008E24 RID: 36388 RVA: 0x000CAB4C File Offset: 0x000C8D4C
		public virtual double[] GetV2()
		{
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV2_29(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008E25 RID: 36389
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetV2_30(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Set/Get the v2 vector of the plane.
		/// </summary>
		// Token: 0x06008E26 RID: 36390 RVA: 0x000CAB94 File Offset: 0x000C8D94
		public virtual void GetV2(ref double _arg1, ref double _arg2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV2_30(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x06008E27 RID: 36391
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_GetV2_31(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the v2 vector of the plane.
		/// </summary>
		// Token: 0x06008E28 RID: 36392 RVA: 0x000CABA5 File Offset: 0x000C8DA5
		public virtual void GetV2(IntPtr _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV2_31(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E29 RID: 36393
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_GetV2HandleProperty_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the handle properties (the little balls are the handles). The
		/// properties of the handles, when selected or normal, can be
		/// specified.
		/// </summary>
		// Token: 0x06008E2A RID: 36394 RVA: 0x000CABB8 File Offset: 0x000C8DB8
		public virtual vtkProperty GetV2HandleProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_GetV2HandleProperty_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008E2B RID: 36395
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_HandlesOff_33(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x06008E2C RID: 36396 RVA: 0x000CAC27 File Offset: 0x000C8E27
		public virtual void HandlesOff()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_HandlesOff_33(base.GetCppThis());
		}

		// Token: 0x06008E2D RID: 36397
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_HandlesOn_34(HandleRef pThis);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x06008E2E RID: 36398 RVA: 0x000CAC36 File Offset: 0x000C8E36
		public virtual void HandlesOn()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_HandlesOn_34(base.GetCppThis());
		}

		// Token: 0x06008E2F RID: 36399
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_HasTranslucentPolygonalGeometry_35(HandleRef pThis);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008E30 RID: 36400 RVA: 0x000CAC48 File Offset: 0x000C8E48
		public override int HasTranslucentPolygonalGeometry()
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_HasTranslucentPolygonalGeometry_35(base.GetCppThis());
		}

		// Token: 0x06008E31 RID: 36401
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_IsA_36(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E32 RID: 36402 RVA: 0x000CAC68 File Offset: 0x000C8E68
		public override int IsA(string type)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_IsA_36(base.GetCppThis(), type);
		}

		// Token: 0x06008E33 RID: 36403
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_IsTypeOf_37([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E34 RID: 36404 RVA: 0x000CAC88 File Offset: 0x000C8E88
		public new static int IsTypeOf(string type)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_IsTypeOf_37(type);
		}

		// Token: 0x06008E35 RID: 36405
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_MovePoint1_38(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E36 RID: 36406 RVA: 0x000CACA2 File Offset: 0x000C8EA2
		public void MovePoint1(IntPtr p1, IntPtr p2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_MovePoint1_38(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06008E37 RID: 36407
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_MovePoint2_39(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E38 RID: 36408 RVA: 0x000CACB3 File Offset: 0x000C8EB3
		public void MovePoint2(IntPtr p1, IntPtr p2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_MovePoint2_39(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06008E39 RID: 36409
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E3A RID: 36410 RVA: 0x000CACC4 File Offset: 0x000C8EC4
		public new vtkFinitePlaneRepresentation NewInstance()
		{
			vtkFinitePlaneRepresentation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008E3B RID: 36411
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_PlaceWidget_42(HandleRef pThis, IntPtr bounds);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008E3C RID: 36412 RVA: 0x000CAD1E File Offset: 0x000C8F1E
		public override void PlaceWidget(IntPtr bounds)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_PlaceWidget_42(base.GetCppThis(), bounds);
		}

		// Token: 0x06008E3D RID: 36413
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_Push_43(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E3E RID: 36414 RVA: 0x000CAD2E File Offset: 0x000C8F2E
		public void Push(IntPtr p1, IntPtr p2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_Push_43(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06008E3F RID: 36415
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_RegisterPickers_44(HandleRef pThis);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E40 RID: 36416 RVA: 0x000CAD3F File Offset: 0x000C8F3F
		public override void RegisterPickers()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_RegisterPickers_44(base.GetCppThis());
		}

		// Token: 0x06008E41 RID: 36417
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_ReleaseGraphicsResources_45(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008E42 RID: 36418 RVA: 0x000CAD50 File Offset: 0x000C8F50
		public override void ReleaseGraphicsResources(vtkWindow arg0)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_ReleaseGraphicsResources_45(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008E43 RID: 36419
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_RenderOpaqueGeometry_46(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008E44 RID: 36420 RVA: 0x000CAD80 File Offset: 0x000C8F80
		public override int RenderOpaqueGeometry(vtkViewport arg0)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_RenderOpaqueGeometry_46(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008E45 RID: 36421
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFinitePlaneRepresentation_RenderTranslucentPolygonalGeometry_47(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008E46 RID: 36422 RVA: 0x000CADB4 File Offset: 0x000C8FB4
		public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
		{
			return vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_RenderTranslucentPolygonalGeometry_47(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008E47 RID: 36423
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_Rotate_48(HandleRef pThis, int X, int Y, IntPtr p1, IntPtr p2, IntPtr vpn);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E48 RID: 36424 RVA: 0x000CADE8 File Offset: 0x000C8FE8
		public void Rotate(int X, int Y, IntPtr p1, IntPtr p2, IntPtr vpn)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_Rotate_48(base.GetCppThis(), X, Y, p1, p2, vpn);
		}

		// Token: 0x06008E49 RID: 36425
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFinitePlaneRepresentation_SafeDownCast_49(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard vtkObject methods
		/// </summary>
		// Token: 0x06008E4A RID: 36426 RVA: 0x000CAE00 File Offset: 0x000C9000
		public new static vtkFinitePlaneRepresentation SafeDownCast(vtkObjectBase o)
		{
			vtkFinitePlaneRepresentation vtkFinitePlaneRepresentation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SafeDownCast_49((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFinitePlaneRepresentation = (vtkFinitePlaneRepresentation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFinitePlaneRepresentation.Register(null);
				}
			}
			return vtkFinitePlaneRepresentation;
		}

		// Token: 0x06008E4B RID: 36427
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetDrawPlane_50(HandleRef pThis, byte plane);

		/// <summary>
		/// Enable/disable the drawing of the plane. In some cases the plane
		/// interferes with the object that it is operating on (i.e., the
		/// plane interferes with the cut surface it produces producing
		/// z-buffer artifacts.)
		/// </summary>
		// Token: 0x06008E4C RID: 36428 RVA: 0x000CAE7F File Offset: 0x000C907F
		public void SetDrawPlane(bool plane)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetDrawPlane_50(base.GetCppThis(), plane ? (byte)1 : (byte)0);
		}

		// Token: 0x06008E4D RID: 36429
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetHandles_51(HandleRef pThis, byte handles);

		/// <summary>
		/// Switches handles (the spheres) on or off by manipulating the underlying
		/// actor visibility.
		/// </summary>
		// Token: 0x06008E4E RID: 36430 RVA: 0x000CAE97 File Offset: 0x000C9097
		public void SetHandles(bool handles)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetHandles_51(base.GetCppThis(), handles ? (byte)1 : (byte)0);
		}

		// Token: 0x06008E4F RID: 36431
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetInteractionState_52(HandleRef pThis, int _arg);

		/// <summary>
		/// Methods supporting, and required by, the rendering process.
		/// </summary>
		// Token: 0x06008E50 RID: 36432 RVA: 0x000CAEAF File Offset: 0x000C90AF
		public virtual void SetInteractionState(int _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetInteractionState_52(base.GetCppThis(), _arg);
		}

		// Token: 0x06008E51 RID: 36433
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetNormal_53(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008E52 RID: 36434 RVA: 0x000CAEBF File Offset: 0x000C90BF
		public void SetNormal(double x, double y, double z)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetNormal_53(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008E53 RID: 36435
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetNormal_54(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Set/Get the normal to the plane.
		/// </summary>
		// Token: 0x06008E54 RID: 36436 RVA: 0x000CAED1 File Offset: 0x000C90D1
		public void SetNormal(IntPtr n)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetNormal_54(base.GetCppThis(), n);
		}

		// Token: 0x06008E55 RID: 36437
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetOrigin_55(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008E56 RID: 36438 RVA: 0x000CAEE1 File Offset: 0x000C90E1
		public void SetOrigin(double x, double y, double z)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetOrigin_55(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008E57 RID: 36439
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetOrigin_56(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the origin of the plane.
		/// </summary>
		// Token: 0x06008E58 RID: 36440 RVA: 0x000CAEF3 File Offset: 0x000C90F3
		public void SetOrigin(IntPtr x)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetOrigin_56(base.GetCppThis(), x);
		}

		// Token: 0x06008E59 RID: 36441
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetRepresentationState_57(HandleRef pThis, int arg0);

		/// <summary>
		/// Sets the visual appearance of the representation based on the
		/// state it is in. This state is usually the same as InteractionState.
		/// </summary>
		// Token: 0x06008E5A RID: 36442 RVA: 0x000CAF03 File Offset: 0x000C9103
		public virtual void SetRepresentationState(int arg0)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetRepresentationState_57(base.GetCppThis(), arg0);
		}

		// Token: 0x06008E5B RID: 36443
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetTubing_58(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06008E5C RID: 36444 RVA: 0x000CAF13 File Offset: 0x000C9113
		public virtual void SetTubing(bool _arg)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetTubing_58(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06008E5D RID: 36445
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetV1_59(HandleRef pThis, double x, double y);

		/// <summary>
		/// Set/Get the v1 vector of the plane.
		/// </summary>
		// Token: 0x06008E5E RID: 36446 RVA: 0x000CAF2B File Offset: 0x000C912B
		public void SetV1(double x, double y)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetV1_59(base.GetCppThis(), x, y);
		}

		// Token: 0x06008E5F RID: 36447
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetV1_60(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the v1 vector of the plane.
		/// </summary>
		// Token: 0x06008E60 RID: 36448 RVA: 0x000CAF3C File Offset: 0x000C913C
		public void SetV1(IntPtr x)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetV1_60(base.GetCppThis(), x);
		}

		// Token: 0x06008E61 RID: 36449
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetV2_61(HandleRef pThis, double x, double y);

		/// <summary>
		/// Set/Get the v2 vector of the plane.
		/// </summary>
		// Token: 0x06008E62 RID: 36450 RVA: 0x000CAF4C File Offset: 0x000C914C
		public void SetV2(double x, double y)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetV2_61(base.GetCppThis(), x, y);
		}

		// Token: 0x06008E63 RID: 36451
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_SetV2_62(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Set/Get the v2 vector of the plane.
		/// </summary>
		// Token: 0x06008E64 RID: 36452 RVA: 0x000CAF5D File Offset: 0x000C915D
		public void SetV2(IntPtr x)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_SetV2_62(base.GetCppThis(), x);
		}

		// Token: 0x06008E65 RID: 36453
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_StartWidgetInteraction_63(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008E66 RID: 36454 RVA: 0x000CAF6D File Offset: 0x000C916D
		public override void StartWidgetInteraction(IntPtr e)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_StartWidgetInteraction_63(base.GetCppThis(), e);
		}

		// Token: 0x06008E67 RID: 36455
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_TranslateOrigin_64(HandleRef pThis, IntPtr p1, IntPtr p2);

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x06008E68 RID: 36456 RVA: 0x000CAF7D File Offset: 0x000C917D
		public void TranslateOrigin(IntPtr p1, IntPtr p2)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_TranslateOrigin_64(base.GetCppThis(), p1, p2);
		}

		// Token: 0x06008E69 RID: 36457
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_TubingOff_65(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06008E6A RID: 36458 RVA: 0x000CAF8E File Offset: 0x000C918E
		public virtual void TubingOff()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_TubingOff_65(base.GetCppThis());
		}

		// Token: 0x06008E6B RID: 36459
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_TubingOn_66(HandleRef pThis);

		/// <summary>
		/// Turn on/off tubing of the wire outline of the plane. The tube thickens
		/// the line by wrapping with a vtkTubeFilter.
		/// </summary>
		// Token: 0x06008E6C RID: 36460 RVA: 0x000CAF9D File Offset: 0x000C919D
		public virtual void TubingOn()
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_TubingOn_66(base.GetCppThis());
		}

		// Token: 0x06008E6D RID: 36461
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFinitePlaneRepresentation_WidgetInteraction_67(HandleRef pThis, IntPtr e);

		/// <summary>
		/// These are methods that satisfy vtkWidgetRepresentation's API.
		/// </summary>
		// Token: 0x06008E6E RID: 36462 RVA: 0x000CAFAC File Offset: 0x000C91AC
		public override void WidgetInteraction(IntPtr e)
		{
			vtkFinitePlaneRepresentation.vtkFinitePlaneRepresentation_WidgetInteraction_67(base.GetCppThis(), e);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BE2 RID: 3042
		public new const string MRFullTypeName = "Kitware.VTK.vtkFinitePlaneRepresentation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BE3 RID: 3043
		public new static readonly string MRClassNameKey = "class vtkFinitePlaneRepresentation";

		/// <summary>
		/// Get the properties on the normal (line and cone).
		/// </summary>
		// Token: 0x02000318 RID: 792
		public enum InteractionStateType
		{
			/// <summary>enum member</summary>
			// Token: 0x04000BE5 RID: 3045
			ModifyV1 = 2,
			/// <summary>enum member</summary>
			// Token: 0x04000BE6 RID: 3046
			ModifyV2,
			/// <summary>enum member</summary>
			// Token: 0x04000BE7 RID: 3047
			MoveOrigin = 1,
			/// <summary>enum member</summary>
			// Token: 0x04000BE8 RID: 3048
			Moving = 4,
			/// <summary>enum member</summary>
			// Token: 0x04000BE9 RID: 3049
			Outside = 0,
			/// <summary>enum member</summary>
			// Token: 0x04000BEA RID: 3050
			Pushing = 6,
			/// <summary>enum member</summary>
			// Token: 0x04000BEB RID: 3051
			Rotating = 5
		}
	}
}
