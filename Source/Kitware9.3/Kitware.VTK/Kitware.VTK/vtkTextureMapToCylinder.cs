using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextureMapToCylinder
	/// </summary>
	/// <remarks>
	///    generate texture coordinates by mapping points to cylinder
	///
	/// vtkTextureMapToCylinder is a filter that generates 2D texture coordinates
	/// by mapping input dataset points onto a cylinder. The cylinder can either be
	/// user specified or generated automatically. (The cylinder is generated
	/// automatically by computing the axis of the cylinder.)  Note that the
	/// generated texture coordinates for the s-coordinate ranges from (0-1)
	/// (corresponding to angle of 0-&gt;360 around axis), while the mapping of
	/// the t-coordinate is controlled by the projection of points along the axis.
	///
	/// To specify a cylinder manually, you must provide two points that
	/// define the axis of the cylinder. The length of the axis will affect the
	/// t-coordinates.
	///
	/// A special ivar controls how the s-coordinate is generated. If PreventSeam
	/// is set to true, the s-texture varies from 0-&gt;1 and then 1-&gt;0 (corresponding
	/// to angles of 0-&gt;180 and 180-&gt;360).
	///
	/// @warning
	/// Since the resulting texture s-coordinate will lie between (0,1), and the
	/// origin of the texture coordinates is not user-controllable, you may want
	/// to use the class vtkTransformTexture to linearly scale and shift the origin
	/// of the texture coordinates.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextureMapToPlane vtkTextureMapToSphere
	/// vtkTransformTexture vtkThresholdTextureCoords
	/// </seealso>
	// Token: 0x02000541 RID: 1345
	public class vtkTextureMapToCylinder : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EF57 RID: 61271 RVA: 0x0014DC0D File Offset: 0x0014BE0D
		static vtkTextureMapToCylinder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToCylinder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToCylinder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF58 RID: 61272 RVA: 0x0014DC35 File Offset: 0x0014BE35
		public vtkTextureMapToCylinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EF59 RID: 61273
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToCylinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with cylinder axis parallel to z-axis (points (0,0,-0.5)
		/// and (0,0,0.5)). The PreventSeam ivar is set to true. The cylinder is
		/// automatically generated.
		/// </summary>
		// Token: 0x0600EF5A RID: 61274 RVA: 0x0014DC44 File Offset: 0x0014BE44
		public new static vtkTextureMapToCylinder New()
		{
			vtkTextureMapToCylinder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with cylinder axis parallel to z-axis (points (0,0,-0.5)
		/// and (0,0,0.5)). The PreventSeam ivar is set to true. The cylinder is
		/// automatically generated.
		/// </summary>
		// Token: 0x0600EF5B RID: 61275 RVA: 0x0014DC98 File Offset: 0x0014BE98
		public vtkTextureMapToCylinder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextureMapToCylinder.vtkTextureMapToCylinder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EF5C RID: 61276 RVA: 0x0014DCDC File Offset: 0x0014BEDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EF5D RID: 61277
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic cylinder generation. This means it automatically
		/// finds the cylinder center and axis.
		/// </summary>
		// Token: 0x0600EF5E RID: 61278 RVA: 0x0014DCE7 File Offset: 0x0014BEE7
		public virtual void AutomaticCylinderGenerationOff()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_AutomaticCylinderGenerationOff_01(base.GetCppThis());
		}

		// Token: 0x0600EF5F RID: 61279
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic cylinder generation. This means it automatically
		/// finds the cylinder center and axis.
		/// </summary>
		// Token: 0x0600EF60 RID: 61280 RVA: 0x0014DCF6 File Offset: 0x0014BEF6
		public virtual void AutomaticCylinderGenerationOn()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_AutomaticCylinderGenerationOn_02(base.GetCppThis());
		}

		// Token: 0x0600EF61 RID: 61281
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic cylinder generation. This means it automatically
		/// finds the cylinder center and axis.
		/// </summary>
		// Token: 0x0600EF62 RID: 61282 RVA: 0x0014DD08 File Offset: 0x0014BF08
		public virtual int GetAutomaticCylinderGeneration()
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetAutomaticCylinderGeneration_03(base.GetCppThis());
		}

		// Token: 0x0600EF63 RID: 61283
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToCylinder_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF64 RID: 61284 RVA: 0x0014DD28 File Offset: 0x0014BF28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EF65 RID: 61285
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToCylinder_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF66 RID: 61286 RVA: 0x0014DD48 File Offset: 0x0014BF48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600EF67 RID: 61287
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToCylinder_GetPoint1_06(HandleRef pThis);

		/// <summary>
		/// Specify the first point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF68 RID: 61288 RVA: 0x0014DD64 File Offset: 0x0014BF64
		public virtual double[] GetPoint1()
		{
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint1_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EF69 RID: 61289
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_GetPoint1_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the first point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF6A RID: 61290 RVA: 0x0014DDAC File Offset: 0x0014BFAC
		public virtual void GetPoint1(IntPtr data)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint1_07(base.GetCppThis(), data);
		}

		// Token: 0x0600EF6B RID: 61291
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToCylinder_GetPoint2_08(HandleRef pThis);

		/// <summary>
		/// Specify the second point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF6C RID: 61292 RVA: 0x0014DDBC File Offset: 0x0014BFBC
		public virtual double[] GetPoint2()
		{
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint2_08(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EF6D RID: 61293
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_GetPoint2_09(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the second point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF6E RID: 61294 RVA: 0x0014DE04 File Offset: 0x0014C004
		public virtual void GetPoint2(IntPtr data)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPoint2_09(base.GetCppThis(), data);
		}

		// Token: 0x0600EF6F RID: 61295
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToCylinder_GetPreventSeam_10(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
		/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EF70 RID: 61296 RVA: 0x0014DE14 File Offset: 0x0014C014
		public virtual int GetPreventSeam()
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_GetPreventSeam_10(base.GetCppThis());
		}

		// Token: 0x0600EF71 RID: 61297
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToCylinder_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF72 RID: 61298 RVA: 0x0014DE34 File Offset: 0x0014C034
		public override int IsA(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600EF73 RID: 61299
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToCylinder_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF74 RID: 61300 RVA: 0x0014DE54 File Offset: 0x0014C054
		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToCylinder.vtkTextureMapToCylinder_IsTypeOf_12(type);
		}

		// Token: 0x0600EF75 RID: 61301
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToCylinder_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF76 RID: 61302 RVA: 0x0014DE70 File Offset: 0x0014C070
		public new vtkTextureMapToCylinder NewInstance()
		{
			vtkTextureMapToCylinder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EF77 RID: 61303
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_PreventSeamOff_15(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
		/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EF78 RID: 61304 RVA: 0x0014DECA File Offset: 0x0014C0CA
		public virtual void PreventSeamOff()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_PreventSeamOff_15(base.GetCppThis());
		}

		// Token: 0x0600EF79 RID: 61305
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_PreventSeamOn_16(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
		/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EF7A RID: 61306 RVA: 0x0014DED9 File Offset: 0x0014C0D9
		public virtual void PreventSeamOn()
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_PreventSeamOn_16(base.GetCppThis());
		}

		// Token: 0x0600EF7B RID: 61307
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToCylinder_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EF7C RID: 61308 RVA: 0x0014DEE8 File Offset: 0x0014C0E8
		public new static vtkTextureMapToCylinder SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToCylinder vtkTextureMapToCylinder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToCylinder.vtkTextureMapToCylinder_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToCylinder = (vtkTextureMapToCylinder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToCylinder.Register(null);
				}
			}
			return vtkTextureMapToCylinder;
		}

		// Token: 0x0600EF7D RID: 61309
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic cylinder generation. This means it automatically
		/// finds the cylinder center and axis.
		/// </summary>
		// Token: 0x0600EF7E RID: 61310 RVA: 0x0014DF67 File Offset: 0x0014C167
		public virtual void SetAutomaticCylinderGeneration(int _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetAutomaticCylinderGeneration_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF7F RID: 61311
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetPoint1_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the first point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF80 RID: 61312 RVA: 0x0014DF77 File Offset: 0x0014C177
		public virtual void SetPoint1(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint1_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EF81 RID: 61313
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetPoint1_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the first point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF82 RID: 61314 RVA: 0x0014DF89 File Offset: 0x0014C189
		public virtual void SetPoint1(IntPtr _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint1_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF83 RID: 61315
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetPoint2_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify the second point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF84 RID: 61316 RVA: 0x0014DF99 File Offset: 0x0014C199
		public virtual void SetPoint2(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint2_21(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EF85 RID: 61317
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetPoint2_22(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the second point defining the cylinder axis,
		/// </summary>
		// Token: 0x0600EF86 RID: 61318 RVA: 0x0014DFAB File Offset: 0x0014C1AB
		public virtual void SetPoint2(IntPtr _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPoint2_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EF87 RID: 61319
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToCylinder_SetPreventSeam_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// angle variation from 0-&gt;180 and 180-&gt;0. Otherwise, the s-coordinate
		/// ranges from 0-&gt;1 from 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EF88 RID: 61320 RVA: 0x0014DFBB File Offset: 0x0014C1BB
		public virtual void SetPreventSeam(int _arg)
		{
			vtkTextureMapToCylinder.vtkTextureMapToCylinder_SetPreventSeam_23(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117A RID: 4474
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToCylinder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400117B RID: 4475
		public new static readonly string MRClassNameKey = "class vtkTextureMapToCylinder";
	}
}
