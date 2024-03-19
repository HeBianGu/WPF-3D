using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDistanceRepresentation3D
	/// </summary>
	/// <remarks>
	///    represent the vtkDistanceWidget
	///
	/// The vtkDistanceRepresentation3D is a representation for the
	/// vtkDistanceWidget. This representation consists of a measuring line (axis)
	/// and two vtkHandleWidgets to place the end points of the line. Note that
	/// this particular widget draws its representation in 3D space, so the widget
	/// can be occluded.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDistanceWidget vtkDistanceRepresentation vtkDistanceRepresentation2D
	/// </seealso>
	// Token: 0x0200030F RID: 783
	public class vtkDistanceRepresentation3D : vtkDistanceRepresentation
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06008CE6 RID: 36070 RVA: 0x000C8DC3 File Offset: 0x000C6FC3
		static vtkDistanceRepresentation3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDistanceRepresentation3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistanceRepresentation3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06008CE7 RID: 36071 RVA: 0x000C8DEB File Offset: 0x000C6FEB
		public vtkDistanceRepresentation3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06008CE8 RID: 36072
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008CE9 RID: 36073 RVA: 0x000C8DFC File Offset: 0x000C6FFC
		public new static vtkDistanceRepresentation3D New()
		{
			vtkDistanceRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Instantiate class.
		/// </summary>
		// Token: 0x06008CEA RID: 36074 RVA: 0x000C8E50 File Offset: 0x000C7050
		public vtkDistanceRepresentation3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06008CEB RID: 36075 RVA: 0x000C8E94 File Offset: 0x000C7094
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06008CEC RID: 36076
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_BuildRepresentation_01(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06008CED RID: 36077 RVA: 0x000C8E9F File Offset: 0x000C709F
		public override void BuildRepresentation()
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_BuildRepresentation_01(base.GetCppThis());
		}

		// Token: 0x06008CEE RID: 36078
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetBounds_02(HandleRef pThis);

		/// <summary>
		/// Method to satisfy superclasses' API.
		/// </summary>
		// Token: 0x06008CEF RID: 36079 RVA: 0x000C8EB0 File Offset: 0x000C70B0
		public override double[] GetBounds()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetBounds_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008CF0 RID: 36080
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation3D_GetDistance_03(HandleRef pThis);

		/// <summary>
		/// Satisfy the superclasses API.
		/// </summary>
		// Token: 0x06008CF1 RID: 36081 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		public override double GetDistance()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetDistance_03(base.GetCppThis());
		}

		// Token: 0x06008CF2 RID: 36082
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetGlyphActor_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the glyph actor. Using this it is
		/// possible to control the appearance of the glyphs.
		/// </summary>
		// Token: 0x06008CF3 RID: 36083 RVA: 0x000C8F18 File Offset: 0x000C7118
		public virtual vtkActor GetGlyphActor()
		{
			vtkActor vtkActor = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetGlyphActor_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkActor = (vtkActor)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkActor.Register(null);
				}
			}
			return vtkActor;
		}

		// Token: 0x06008CF4 RID: 36084
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation3D_GetGlyphScale_05(HandleRef pThis);

		/// <summary>
		/// Scale the glyphs used as tick marks. By default it is
		/// 1/40th of the length.
		/// </summary>
		// Token: 0x06008CF5 RID: 36085 RVA: 0x000C8F88 File Offset: 0x000C7188
		public virtual double GetGlyphScale()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetGlyphScale_05(base.GetCppThis());
		}

		// Token: 0x06008CF6 RID: 36086
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelActor_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method Get the label actor. It is possible to
		/// control the appearance of the label.
		/// </summary>
		// Token: 0x06008CF7 RID: 36087 RVA: 0x000C8FA8 File Offset: 0x000C71A8
		public virtual vtkFollower GetLabelActor()
		{
			vtkFollower vtkFollower = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelActor_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFollower = (vtkFollower)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFollower.Register(null);
				}
			}
			return vtkFollower;
		}

		// Token: 0x06008CF8 RID: 36088
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDistanceRepresentation3D_GetLabelPosition_07(HandleRef pThis);

		/// <summary>
		/// Set/Get position of the label title in normalized coordinates [0,1].
		/// 0 is at the start of the line whereas 1 is at the end.
		/// </summary>
		// Token: 0x06008CF9 RID: 36089 RVA: 0x000C9018 File Offset: 0x000C7218
		public virtual double GetLabelPosition()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelPosition_07(base.GetCppThis());
		}

		// Token: 0x06008CFA RID: 36090
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelProperty_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the distance annotation property
		/// </summary>
		// Token: 0x06008CFB RID: 36091 RVA: 0x000C9038 File Offset: 0x000C7238
		public virtual vtkProperty GetLabelProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelProperty_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008CFC RID: 36092
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLabelScale_09(HandleRef pThis);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06008CFD RID: 36093 RVA: 0x000C90A8 File Offset: 0x000C72A8
		public virtual IntPtr GetLabelScale()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLabelScale_09(base.GetCppThis());
		}

		// Token: 0x06008CFE RID: 36094
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetLineProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Convenience method to get the line actor property.
		/// </summary>
		// Token: 0x06008CFF RID: 36095 RVA: 0x000C90C8 File Offset: 0x000C72C8
		public virtual vtkProperty GetLineProperty()
		{
			vtkProperty vtkProperty = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetLineProperty_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06008D00 RID: 36096
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of ticks in ruler mode.
		/// </summary>
		// Token: 0x06008D01 RID: 36097 RVA: 0x000C9138 File Offset: 0x000C7338
		public virtual int GetMaximumNumberOfRulerTicks()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicks_11(base.GetCppThis());
		}

		// Token: 0x06008D02 RID: 36098
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of ticks in ruler mode.
		/// </summary>
		// Token: 0x06008D03 RID: 36099 RVA: 0x000C9158 File Offset: 0x000C7358
		public virtual int GetMaximumNumberOfRulerTicksMaxValue()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMaxValue_12(base.GetCppThis());
		}

		// Token: 0x06008D04 RID: 36100
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the maximum number of ticks in ruler mode.
		/// </summary>
		// Token: 0x06008D05 RID: 36101 RVA: 0x000C9178 File Offset: 0x000C7378
		public virtual int GetMaximumNumberOfRulerTicksMinValue()
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetMaximumNumberOfRulerTicksMinValue_13(base.GetCppThis());
		}

		// Token: 0x06008D06 RID: 36102
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBase_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D07 RID: 36103 RVA: 0x000C9198 File Offset: 0x000C7398
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBase_14(base.GetCppThis(), type);
		}

		// Token: 0x06008D08 RID: 36104
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBaseType_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D09 RID: 36105 RVA: 0x000C91B8 File Offset: 0x000C73B8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetNumberOfGenerationsFromBaseType_15(type);
		}

		// Token: 0x06008D0A RID: 36106
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_GetPoint1DisplayPosition_16(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D0B RID: 36107 RVA: 0x000C91D2 File Offset: 0x000C73D2
		public override void GetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1DisplayPosition_16(base.GetCppThis(), pos);
		}

		// Token: 0x06008D0C RID: 36108
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint1WorldPosition_17(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D0D RID: 36109 RVA: 0x000C91E4 File Offset: 0x000C73E4
		public override double[] GetPoint1WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1WorldPosition_17(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008D0E RID: 36110
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_GetPoint1WorldPosition_18(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D0F RID: 36111 RVA: 0x000C922C File Offset: 0x000C742C
		public override void GetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint1WorldPosition_18(base.GetCppThis(), pos);
		}

		// Token: 0x06008D10 RID: 36112
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_GetPoint2DisplayPosition_19(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D11 RID: 36113 RVA: 0x000C923C File Offset: 0x000C743C
		public override void GetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2DisplayPosition_19(base.GetCppThis(), pos);
		}

		// Token: 0x06008D12 RID: 36114
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_GetPoint2WorldPosition_20(HandleRef pThis);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D13 RID: 36115 RVA: 0x000C924C File Offset: 0x000C744C
		public override double[] GetPoint2WorldPosition()
		{
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2WorldPosition_20(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06008D14 RID: 36116
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_GetPoint2WorldPosition_21(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D15 RID: 36117 RVA: 0x000C9294 File Offset: 0x000C7494
		public override void GetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_GetPoint2WorldPosition_21(base.GetCppThis(), pos);
		}

		// Token: 0x06008D16 RID: 36118
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_IsA_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D17 RID: 36119 RVA: 0x000C92A4 File Offset: 0x000C74A4
		public override int IsA(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_IsA_22(base.GetCppThis(), type);
		}

		// Token: 0x06008D18 RID: 36120
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_IsTypeOf_23([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D19 RID: 36121 RVA: 0x000C92C4 File Offset: 0x000C74C4
		public new static int IsTypeOf(string type)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_IsTypeOf_23(type);
		}

		// Token: 0x06008D1A RID: 36122
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D1B RID: 36123 RVA: 0x000C92E0 File Offset: 0x000C74E0
		public new vtkDistanceRepresentation3D NewInstance()
		{
			vtkDistanceRepresentation3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_NewInstance_25(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06008D1C RID: 36124
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef w);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008D1D RID: 36125 RVA: 0x000C933C File Offset: 0x000C753C
		public override void ReleaseGraphicsResources(vtkWindow w)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_ReleaseGraphicsResources_26(base.GetCppThis(), (w == null) ? default(HandleRef) : w.GetCppThis());
		}

		// Token: 0x06008D1E RID: 36126
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008D1F RID: 36127 RVA: 0x000C936C File Offset: 0x000C756C
		public override int RenderOpaqueGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_RenderOpaqueGeometry_27(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008D20 RID: 36128
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_28(HandleRef pThis, HandleRef viewport);

		/// <summary>
		/// Methods required by vtkProp superclass.
		/// </summary>
		// Token: 0x06008D21 RID: 36129 RVA: 0x000C93A0 File Offset: 0x000C75A0
		public override int RenderTranslucentPolygonalGeometry(vtkViewport viewport)
		{
			return vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_RenderTranslucentPolygonalGeometry_28(base.GetCppThis(), (viewport == null) ? default(HandleRef) : viewport.GetCppThis());
		}

		// Token: 0x06008D22 RID: 36130
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDistanceRepresentation3D_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard VTK methods.
		/// </summary>
		// Token: 0x06008D23 RID: 36131 RVA: 0x000C93D4 File Offset: 0x000C75D4
		public new static vtkDistanceRepresentation3D SafeDownCast(vtkObjectBase o)
		{
			vtkDistanceRepresentation3D vtkDistanceRepresentation3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SafeDownCast_29((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDistanceRepresentation3D = (vtkDistanceRepresentation3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDistanceRepresentation3D.Register(null);
				}
			}
			return vtkDistanceRepresentation3D;
		}

		// Token: 0x06008D24 RID: 36132
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetGlyphScale_30(HandleRef pThis, double scale);

		/// <summary>
		/// Scale the glyphs used as tick marks. By default it is
		/// 1/40th of the length.
		/// </summary>
		// Token: 0x06008D25 RID: 36133 RVA: 0x000C9453 File Offset: 0x000C7653
		public void SetGlyphScale(double scale)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetGlyphScale_30(base.GetCppThis(), scale);
		}

		// Token: 0x06008D26 RID: 36134
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetLabelActor_31(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Convenience method Get the label actor. It is possible to
		/// control the appearance of the label.
		/// </summary>
		// Token: 0x06008D27 RID: 36135 RVA: 0x000C9464 File Offset: 0x000C7664
		public virtual void SetLabelActor(vtkFollower arg0)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelActor_31(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06008D28 RID: 36136
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetLabelPosition_32(HandleRef pThis, double labelPosition);

		/// <summary>
		/// Set/Get position of the label title in normalized coordinates [0,1].
		/// 0 is at the start of the line whereas 1 is at the end.
		/// </summary>
		// Token: 0x06008D29 RID: 36137 RVA: 0x000C9493 File Offset: 0x000C7693
		public void SetLabelPosition(double labelPosition)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelPosition_32(base.GetCppThis(), labelPosition);
		}

		// Token: 0x06008D2A RID: 36138
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetLabelScale_33(HandleRef pThis, double x, double y, double z);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06008D2B RID: 36139 RVA: 0x000C94A3 File Offset: 0x000C76A3
		public void SetLabelScale(double x, double y, double z)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelScale_33(base.GetCppThis(), x, y, z);
		}

		// Token: 0x06008D2C RID: 36140
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetLabelScale_34(HandleRef pThis, IntPtr scale);

		/// <summary>
		/// Scale text (font size along each dimension). This helps control
		/// the appearance of the 3D text.
		/// </summary>
		// Token: 0x06008D2D RID: 36141 RVA: 0x000C94B5 File Offset: 0x000C76B5
		public virtual void SetLabelScale(IntPtr scale)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetLabelScale_34(base.GetCppThis(), scale);
		}

		// Token: 0x06008D2E RID: 36142
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the maximum number of ticks in ruler mode.
		/// </summary>
		// Token: 0x06008D2F RID: 36143 RVA: 0x000C94C5 File Offset: 0x000C76C5
		public virtual void SetMaximumNumberOfRulerTicks(int _arg)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetMaximumNumberOfRulerTicks_35(base.GetCppThis(), _arg);
		}

		// Token: 0x06008D30 RID: 36144
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetPoint1DisplayPosition_36(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D31 RID: 36145 RVA: 0x000C94D5 File Offset: 0x000C76D5
		public override void SetPoint1DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint1DisplayPosition_36(base.GetCppThis(), pos);
		}

		// Token: 0x06008D32 RID: 36146
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetPoint1WorldPosition_37(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D33 RID: 36147 RVA: 0x000C94E5 File Offset: 0x000C76E5
		public override void SetPoint1WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint1WorldPosition_37(base.GetCppThis(), pos);
		}

		// Token: 0x06008D34 RID: 36148
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetPoint2DisplayPosition_38(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D35 RID: 36149 RVA: 0x000C94F5 File Offset: 0x000C76F5
		public override void SetPoint2DisplayPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint2DisplayPosition_38(base.GetCppThis(), pos);
		}

		// Token: 0x06008D36 RID: 36150
		[DllImport("Kitware.VTK.InteractionWidgets.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDistanceRepresentation3D_SetPoint2WorldPosition_39(HandleRef pThis, IntPtr pos);

		/// <summary>
		/// Methods to Set/Get the coordinates of the two points defining
		/// this representation. Note that methods are available for both
		/// display and world coordinates.
		/// </summary>
		// Token: 0x06008D37 RID: 36151 RVA: 0x000C9505 File Offset: 0x000C7705
		public override void SetPoint2WorldPosition(IntPtr pos)
		{
			vtkDistanceRepresentation3D.vtkDistanceRepresentation3D_SetPoint2WorldPosition_39(base.GetCppThis(), pos);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCC RID: 3020
		public new const string MRFullTypeName = "Kitware.VTK.vtkDistanceRepresentation3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000BCD RID: 3021
		public new static readonly string MRClassNameKey = "class vtkDistanceRepresentation3D";
	}
}
