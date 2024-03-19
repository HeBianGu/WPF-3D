using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDrawTexturedElements
	/// </summary>
	/// <remarks>
	///    A base class for mappers or render responders that need to
	///          draw primitives via vertex-pulling.
	///
	/// Since this class is intended to be inherited by other classes that
	/// must *also* inherit a VTK mapper or responder class, it is not a
	/// subclass of vtkObject; instead, it provides methods your subclass
	/// can invoke during rendering.
	///
	/// This currently handles hexahedra and tetrahedra.
	/// </remarks>
	// Token: 0x02000587 RID: 1415
	public class vtkDrawTexturedElements : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600FA1E RID: 64030 RVA: 0x0015BCA3 File Offset: 0x00159EA3
		static vtkDrawTexturedElements()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDrawTexturedElements.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDrawTexturedElements"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA1F RID: 64031 RVA: 0x0015BCCB File Offset: 0x00159ECB
		public vtkDrawTexturedElements(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600FA20 RID: 64032 RVA: 0x0015BCD9 File Offset: 0x00159ED9
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600FA21 RID: 64033
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDrawTexturedElements_BindArrayToTexture_01(HandleRef pThis, vtkStringToken textureName, HandleRef array, byte asScalars);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA22 RID: 64034 RVA: 0x0015BCE4 File Offset: 0x00159EE4
		public void BindArrayToTexture(vtkStringToken textureName, vtkDataArray array, bool asScalars)
		{
			vtkDrawTexturedElements.vtkDrawTexturedElements_BindArrayToTexture_01(base.GetCppThis(), textureName, (array == null) ? default(HandleRef) : array.GetCppThis(), asScalars ? (byte)1 : (byte)0);
		}

		// Token: 0x0600FA23 RID: 64035
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDrawTexturedElements_DrawInstancedElements_02(HandleRef pThis, HandleRef ren, HandleRef a, HandleRef mapper);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA24 RID: 64036 RVA: 0x0015BD20 File Offset: 0x00159F20
		public void DrawInstancedElements(vtkRenderer ren, vtkActor a, vtkMapper mapper)
		{
			vtkDrawTexturedElements.vtkDrawTexturedElements_DrawInstancedElements_02(base.GetCppThis(), (ren == null) ? default(HandleRef) : ren.GetCppThis(), (a == null) ? default(HandleRef) : a.GetCppThis(), (mapper == null) ? default(HandleRef) : mapper.GetCppThis());
		}

		// Token: 0x0600FA25 RID: 64037
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDrawTexturedElements_GetElementType_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA26 RID: 64038 RVA: 0x0015BD7C File Offset: 0x00159F7C
		public int GetElementType()
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_GetElementType_03(base.GetCppThis());
		}

		// Token: 0x0600FA27 RID: 64039
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDrawTexturedElements_GetGLSLModCollection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA28 RID: 64040 RVA: 0x0015BD9C File Offset: 0x00159F9C
		public vtkCollection GetGLSLModCollection()
		{
			vtkCollection vtkCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDrawTexturedElements.vtkDrawTexturedElements_GetGLSLModCollection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCollection = (vtkCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCollection.Register(null);
				}
			}
			return vtkCollection;
		}

		// Token: 0x0600FA29 RID: 64041
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_GetIncludeColormap_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA2A RID: 64042 RVA: 0x0015BE0C File Offset: 0x0015A00C
		public bool GetIncludeColormap()
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_GetIncludeColormap_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0600FA2B RID: 64043
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDrawTexturedElements_GetNumberOfElements_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA2C RID: 64044 RVA: 0x0015BE34 File Offset: 0x0015A034
		public long GetNumberOfElements()
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_GetNumberOfElements_06(base.GetCppThis());
		}

		// Token: 0x0600FA2D RID: 64045
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDrawTexturedElements_GetNumberOfInstances_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA2E RID: 64046 RVA: 0x0015BE54 File Offset: 0x0015A054
		public long GetNumberOfInstances()
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_GetNumberOfInstances_07(base.GetCppThis());
		}

		// Token: 0x0600FA2F RID: 64047
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDrawTexturedElements_GetShader_08(HandleRef pThis, vtkShader.Type shaderType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA30 RID: 64048 RVA: 0x0015BE74 File Offset: 0x0015A074
		public vtkShader GetShader(vtkShader.Type shaderType)
		{
			vtkShader vtkShader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDrawTexturedElements.vtkDrawTexturedElements_GetShader_08(base.GetCppThis(), shaderType, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShader = (vtkShader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShader.Register(null);
				}
			}
			return vtkShader;
		}

		// Token: 0x0600FA31 RID: 64049
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDrawTexturedElements_GetShaderProgram_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA32 RID: 64050 RVA: 0x0015BEE4 File Offset: 0x0015A0E4
		public vtkShaderProgram GetShaderProgram()
		{
			vtkShaderProgram vtkShaderProgram = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDrawTexturedElements.vtkDrawTexturedElements_GetShaderProgram_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShaderProgram = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShaderProgram.Register(null);
				}
			}
			return vtkShaderProgram;
		}

		// Token: 0x0600FA33 RID: 64051
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDrawTexturedElements_ReleaseResources_10(HandleRef pThis, HandleRef window);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA34 RID: 64052 RVA: 0x0015BF54 File Offset: 0x0015A154
		public void ReleaseResources(vtkWindow window)
		{
			vtkDrawTexturedElements.vtkDrawTexturedElements_ReleaseResources_10(base.GetCppThis(), (window == null) ? default(HandleRef) : window.GetCppThis());
		}

		// Token: 0x0600FA35 RID: 64053
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_SetElementType_11(HandleRef pThis, int elementType);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA36 RID: 64054 RVA: 0x0015BF84 File Offset: 0x0015A184
		public virtual bool SetElementType(int elementType)
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_SetElementType_11(base.GetCppThis(), elementType) != 0;
		}

		// Token: 0x0600FA37 RID: 64055
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_SetIncludeColormap_12(HandleRef pThis, byte includeColormap);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA38 RID: 64056 RVA: 0x0015BFAC File Offset: 0x0015A1AC
		public virtual bool SetIncludeColormap(bool includeColormap)
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_SetIncludeColormap_12(base.GetCppThis(), includeColormap ? (byte)1 : (byte)0) != 0;
		}

		// Token: 0x0600FA39 RID: 64057
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_SetNumberOfElements_13(HandleRef pThis, long numberOfElements);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA3A RID: 64058 RVA: 0x0015BFDC File Offset: 0x0015A1DC
		public virtual bool SetNumberOfElements(long numberOfElements)
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_SetNumberOfElements_13(base.GetCppThis(), numberOfElements) != 0;
		}

		// Token: 0x0600FA3B RID: 64059
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_SetNumberOfInstances_14(HandleRef pThis, long numberOfInstances);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA3C RID: 64060 RVA: 0x0015C004 File Offset: 0x0015A204
		public virtual bool SetNumberOfInstances(long numberOfInstances)
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_SetNumberOfInstances_14(base.GetCppThis(), numberOfInstances) != 0;
		}

		// Token: 0x0600FA3D RID: 64061
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDrawTexturedElements_UnbindArray_15(HandleRef pThis, vtkStringToken arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600FA3E RID: 64062 RVA: 0x0015C02C File Offset: 0x0015A22C
		public bool UnbindArray(vtkStringToken arg0)
		{
			return vtkDrawTexturedElements.vtkDrawTexturedElements_UnbindArray_15(base.GetCppThis(), arg0) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001227 RID: 4647
		public new const string MRFullTypeName = "Kitware.VTK.vtkDrawTexturedElements";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001228 RID: 4648
		public new static readonly string MRClassNameKey = "class vtkDrawTexturedElements";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x02000588 RID: 1416
		public enum ElementShape
		{
			/// <summary>enum member</summary>
			// Token: 0x0400122A RID: 4650
			Line = 1,
			/// <summary>enum member</summary>
			// Token: 0x0400122B RID: 4651
			LineStrip,
			/// <summary>enum member</summary>
			// Token: 0x0400122C RID: 4652
			Point = 0,
			/// <summary>enum member</summary>
			// Token: 0x0400122D RID: 4653
			Triangle = 3,
			/// <summary>enum member</summary>
			// Token: 0x0400122E RID: 4654
			TriangleFan = 5,
			/// <summary>enum member</summary>
			// Token: 0x0400122F RID: 4655
			TriangleStrip = 4
		}
	}
}
