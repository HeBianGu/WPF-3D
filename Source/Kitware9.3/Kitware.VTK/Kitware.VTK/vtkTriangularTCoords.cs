using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTriangularTCoords
	/// </summary>
	/// <remarks>
	///    2D texture coordinates based for triangles.
	///
	/// vtkTriangularTCoords is a filter that generates texture coordinates
	/// for triangles. Texture coordinates for each triangle are:
	/// (0,0), (1,0) and (.5,sqrt(3)/2). This filter assumes that the triangle
	/// texture map is symmetric about the center of the triangle. Thus the order
	/// Of the texture coordinates is not important. The procedural texture
	/// in vtkTriangularTexture is designed with this symmetry. For more information
	/// see the paper "Opacity-modulating Triangular Textures for Irregular
	/// Surfaces,"  by Penny Rheingans, IEEE Visualization '96, pp. 219-225.
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangularTexture vtkThresholdPoints vtkTextureMapToPlane
	/// vtkTextureMapToSphere vtkTextureMapToCylinder
	/// </seealso>
	// Token: 0x02000545 RID: 1349
	public class vtkTriangularTCoords : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F04D RID: 61517 RVA: 0x0014EDD1 File Offset: 0x0014CFD1
		static vtkTriangularTCoords()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTriangularTCoords.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTriangularTCoords"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F04E RID: 61518 RVA: 0x0014EDF9 File Offset: 0x0014CFF9
		public vtkTriangularTCoords(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F04F RID: 61519
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTCoords_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F050 RID: 61520 RVA: 0x0014EE08 File Offset: 0x0014D008
		public new static vtkTriangularTCoords New()
		{
			vtkTriangularTCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F051 RID: 61521 RVA: 0x0014EE5C File Offset: 0x0014D05C
		public vtkTriangularTCoords() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTriangularTCoords.vtkTriangularTCoords_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F052 RID: 61522 RVA: 0x0014EEA0 File Offset: 0x0014D0A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F053 RID: 61523
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangularTCoords_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F054 RID: 61524 RVA: 0x0014EEAC File Offset: 0x0014D0AC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F055 RID: 61525
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTriangularTCoords_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F056 RID: 61526 RVA: 0x0014EECC File Offset: 0x0014D0CC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F057 RID: 61527
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTCoords_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F058 RID: 61528 RVA: 0x0014EEE8 File Offset: 0x0014D0E8
		public override int IsA(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F059 RID: 61529
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTriangularTCoords_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F05A RID: 61530 RVA: 0x0014EF08 File Offset: 0x0014D108
		public new static int IsTypeOf(string type)
		{
			return vtkTriangularTCoords.vtkTriangularTCoords_IsTypeOf_04(type);
		}

		// Token: 0x0600F05B RID: 61531
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTCoords_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F05C RID: 61532 RVA: 0x0014EF24 File Offset: 0x0014D124
		public new vtkTriangularTCoords NewInstance()
		{
			vtkTriangularTCoords result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F05D RID: 61533
		[DllImport("Kitware.VTK.FiltersTexture.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTriangularTCoords_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F05E RID: 61534 RVA: 0x0014EF80 File Offset: 0x0014D180
		public new static vtkTriangularTCoords SafeDownCast(vtkObjectBase o)
		{
			vtkTriangularTCoords vtkTriangularTCoords = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTriangularTCoords.vtkTriangularTCoords_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTriangularTCoords = (vtkTriangularTCoords)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTriangularTCoords.Register(null);
				}
			}
			return vtkTriangularTCoords;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001182 RID: 4482
		public new const string MRFullTypeName = "Kitware.VTK.vtkTriangularTCoords";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001183 RID: 4483
		public new static readonly string MRClassNameKey = "class vtkTriangularTCoords";
	}
}
