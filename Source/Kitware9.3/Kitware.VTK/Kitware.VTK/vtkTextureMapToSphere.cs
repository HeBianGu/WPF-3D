using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextureMapToSphere
	/// </summary>
	/// <remarks>
	///    generate texture coordinates by mapping points to sphere
	///
	/// vtkTextureMapToSphere is a filter that generates 2D texture coordinates by
	/// mapping input dataset points onto a sphere. The sphere can either be user
	/// specified or generated automatically. (The sphere is generated
	/// automatically by computing the center (i.e., averaged coordinates) of the
	/// sphere.)  Note that the generated texture coordinates range between
	/// (0,1). The s-coordinate lies in the angular direction around the z-axis,
	/// measured counter-clockwise from the x-axis. The t-coordinate lies in the
	/// angular direction measured down from the north pole towards the south
	/// pole.
	///
	/// A special ivar controls how the s-coordinate is generated. If PreventSeam
	/// is set to true, the s-texture varies from 0-&gt;1 and then 1-&gt;0 (corresponding
	/// to angles of 0-&gt;180 and 180-&gt;360).
	///
	/// @warning
	/// The resulting texture coordinates will lie between (0,1), and the texture
	/// coordinates are determined with respect to the modeler's x-y-z coordinate
	/// system. Use the class vtkTransformTextureCoords to linearly scale and
	/// shift the origin of the texture coordinates (if necessary).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextureMapToPlane vtkTextureMapToCylinder
	/// vtkTransformTexture vtkThresholdTextureCoords
	/// </seealso>
	// Token: 0x02000534 RID: 1332
	public class vtkTextureMapToSphere : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EDC3 RID: 60867 RVA: 0x0014B697 File Offset: 0x00149897
		static vtkTextureMapToSphere()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextureMapToSphere.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextureMapToSphere"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDC4 RID: 60868 RVA: 0x0014B6BF File Offset: 0x001498BF
		public vtkTextureMapToSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EDC5 RID: 60869
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create object with Center (0,0,0) and the PreventSeam ivar is set to
		/// true. The sphere center is automatically computed.
		/// </summary>
		// Token: 0x0600EDC6 RID: 60870 RVA: 0x0014B6D0 File Offset: 0x001498D0
		public new static vtkTextureMapToSphere New()
		{
			vtkTextureMapToSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create object with Center (0,0,0) and the PreventSeam ivar is set to
		/// true. The sphere center is automatically computed.
		/// </summary>
		// Token: 0x0600EDC7 RID: 60871 RVA: 0x0014B724 File Offset: 0x00149924
		public vtkTextureMapToSphere() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextureMapToSphere.vtkTextureMapToSphere_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EDC8 RID: 60872 RVA: 0x0014B768 File Offset: 0x00149968
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EDC9 RID: 60873
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic sphere generation. This means it automatically
		/// finds the sphere center.
		/// </summary>
		// Token: 0x0600EDCA RID: 60874 RVA: 0x0014B773 File Offset: 0x00149973
		public virtual void AutomaticSphereGenerationOff()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_AutomaticSphereGenerationOff_01(base.GetCppThis());
		}

		// Token: 0x0600EDCB RID: 60875
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic sphere generation. This means it automatically
		/// finds the sphere center.
		/// </summary>
		// Token: 0x0600EDCC RID: 60876 RVA: 0x0014B782 File Offset: 0x00149982
		public virtual void AutomaticSphereGenerationOn()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_AutomaticSphereGenerationOn_02(base.GetCppThis());
		}

		// Token: 0x0600EDCD RID: 60877
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_ComputeCenter_03(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
		/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EDCE RID: 60878 RVA: 0x0014B794 File Offset: 0x00149994
		public virtual void ComputeCenter(vtkDataSet input)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_ComputeCenter_03(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x0600EDCF RID: 60879
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToSphere_GetAutomaticSphereGeneration_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off automatic sphere generation. This means it automatically
		/// finds the sphere center.
		/// </summary>
		// Token: 0x0600EDD0 RID: 60880 RVA: 0x0014B7C4 File Offset: 0x001499C4
		public virtual int GetAutomaticSphereGeneration()
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetAutomaticSphereGeneration_04(base.GetCppThis());
		}

		// Token: 0x0600EDD1 RID: 60881
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToSphere_GetCenter_05(HandleRef pThis);

		/// <summary>
		/// Specify a point defining the center of the sphere.
		/// </summary>
		// Token: 0x0600EDD2 RID: 60882 RVA: 0x0014B7E4 File Offset: 0x001499E4
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_GetCenter_05(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600EDD3 RID: 60883
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_GetCenter_06(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify a point defining the center of the sphere.
		/// </summary>
		// Token: 0x0600EDD4 RID: 60884 RVA: 0x0014B82C File Offset: 0x00149A2C
		public virtual void GetCenter(IntPtr data)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_GetCenter_06(base.GetCppThis(), data);
		}

		// Token: 0x0600EDD5 RID: 60885
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToSphere_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDD6 RID: 60886 RVA: 0x0014B83C File Offset: 0x00149A3C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0600EDD7 RID: 60887
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextureMapToSphere_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDD8 RID: 60888 RVA: 0x0014B85C File Offset: 0x00149A5C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0600EDD9 RID: 60889
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToSphere_GetPreventSeam_09(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
		/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EDDA RID: 60890 RVA: 0x0014B878 File Offset: 0x00149A78
		public virtual int GetPreventSeam()
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_GetPreventSeam_09(base.GetCppThis());
		}

		// Token: 0x0600EDDB RID: 60891
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToSphere_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDDC RID: 60892 RVA: 0x0014B898 File Offset: 0x00149A98
		public override int IsA(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600EDDD RID: 60893
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextureMapToSphere_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDDE RID: 60894 RVA: 0x0014B8B8 File Offset: 0x00149AB8
		public new static int IsTypeOf(string type)
		{
			return vtkTextureMapToSphere.vtkTextureMapToSphere_IsTypeOf_11(type);
		}

		// Token: 0x0600EDDF RID: 60895
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToSphere_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDE0 RID: 60896 RVA: 0x0014B8D4 File Offset: 0x00149AD4
		public new vtkTextureMapToSphere NewInstance()
		{
			vtkTextureMapToSphere result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EDE1 RID: 60897
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_PreventSeamOff_14(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
		/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EDE2 RID: 60898 RVA: 0x0014B92E File Offset: 0x00149B2E
		public virtual void PreventSeamOff()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_PreventSeamOff_14(base.GetCppThis());
		}

		// Token: 0x0600EDE3 RID: 60899
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_PreventSeamOn_15(HandleRef pThis);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
		/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EDE4 RID: 60900 RVA: 0x0014B93D File Offset: 0x00149B3D
		public virtual void PreventSeamOn()
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_PreventSeamOn_15(base.GetCppThis());
		}

		// Token: 0x0600EDE5 RID: 60901
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextureMapToSphere_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EDE6 RID: 60902 RVA: 0x0014B94C File Offset: 0x00149B4C
		public new static vtkTextureMapToSphere SafeDownCast(vtkObjectBase o)
		{
			vtkTextureMapToSphere vtkTextureMapToSphere = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextureMapToSphere.vtkTextureMapToSphere_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextureMapToSphere = (vtkTextureMapToSphere)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextureMapToSphere.Register(null);
				}
			}
			return vtkTextureMapToSphere;
		}

		// Token: 0x0600EDE7 RID: 60903
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_SetAutomaticSphereGeneration_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Turn on/off automatic sphere generation. This means it automatically
		/// finds the sphere center.
		/// </summary>
		// Token: 0x0600EDE8 RID: 60904 RVA: 0x0014B9CB File Offset: 0x00149BCB
		public virtual void SetAutomaticSphereGeneration(int _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetAutomaticSphereGeneration_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDE9 RID: 60905
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_SetCenter_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Specify a point defining the center of the sphere.
		/// </summary>
		// Token: 0x0600EDEA RID: 60906 RVA: 0x0014B9DB File Offset: 0x00149BDB
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetCenter_18(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600EDEB RID: 60907
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_SetCenter_19(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify a point defining the center of the sphere.
		/// </summary>
		// Token: 0x0600EDEC RID: 60908 RVA: 0x0014B9ED File Offset: 0x00149BED
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetCenter_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600EDED RID: 60909
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextureMapToSphere_SetPreventSeam_20(HandleRef pThis, int _arg);

		/// <summary>
		/// Control how the texture coordinates are generated. If PreventSeam is
		/// set, the s-coordinate ranges from 0-&gt;1 and 1-&gt;0 corresponding to the
		/// theta angle variation between 0-&gt;180 and 180-&gt;0 degrees. Otherwise, the
		/// s-coordinate ranges from 0-&gt;1 between 0-&gt;360 degrees.
		/// </summary>
		// Token: 0x0600EDEE RID: 60910 RVA: 0x0014B9FD File Offset: 0x00149BFD
		public virtual void SetPreventSeam(int _arg)
		{
			vtkTextureMapToSphere.vtkTextureMapToSphere_SetPreventSeam_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001160 RID: 4448
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextureMapToSphere";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001161 RID: 4449
		public new static readonly string MRClassNameKey = "class vtkTextureMapToSphere";
	}
}
