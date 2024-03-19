using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOpenGLInstanceCulling
	/// </summary>
	/// <remarks>
	///    Frustum culling and LOD management.
	///
	/// This class is used to cull instances based on their transformation matrix.
	/// It was designed to improve performances when there is large number of instances
	/// in vtkOpenGLGlyph3DMapper.
	///
	/// Each instance is tested on the GPU through vertex shader to know if it is inside
	/// of the frustum view. If it is, the distance to the camera is computed to select
	/// and send to the geometry shader the corresponding LOD index.
	/// The geometry shader register the instance to the corresponding vertex stream and
	/// therefore the corresponding transform feedback buffer in video memory.
	///
	/// @warning   GL_ARB_gpu_shader5 extension is required.
	///
	/// @code{.cpp}
	///
	/// vtkNew&lt;vtkOpenGLInstanceCulling&gt; culling;
	/// vtkIdType nbInstances = 1000000;
	///
	/// // buffer of size 16*nbInstances containing transform matrices.
	/// vtkOpenGLBufferObject* bufferMatrix = ...;
	///
	/// // buffer of size 4*nbInstances containing color buffer to pass through.
	/// vtkOpenGLBufferObject* bufferColor = ...;
	///
	/// // Initialize LODs
	/// culling-&gt;InitLOD(polydata); // LOD0 : full geometry
	/// culling-&gt;AddLOD(2.0, 0.5); // LOD1 : after 2.0, 50% triangles
	/// culling-&gt;AddLOD(5.0, 0.99); // LOD2 : after 5.0, 1% triangles
	///
	/// // Build shader and binds
	/// culling-&gt;BuildCullingShaders(ren, actor, nbInstances);
	/// culling-&gt;RunCullingShaders(nbInstances, bufferMatrix, bufferColor);
	///
	/// // Get number of instances in LOD 0
	/// int nbInstInLOD0 = culling-&gt;GetLOD(0).NumberOfInstances;
	///
	/// // Get VBO and IBO of LOD 1
	/// vtkOpenGLBufferObject* VBO1 = culling-&gt;GetLOD(1).PositionVBO;
	/// vtkOpenGLBufferObject* IBO1 = culling-&gt;GetLOD(1).IBO;
	///
	/// // Get instances buffer of LOD 2
	/// // buffer is interleaved [ transformMatrix0 color0 transformMatrix1 color1 ... ]
	/// vtkOpenGLBufferObject* buffer2 = culling-&gt;GetLODBuffer(2);
	///
	/// @endcode
	/// </remarks>
	// Token: 0x020005BA RID: 1466
	public class vtkOpenGLInstanceCulling : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060100BB RID: 65723 RVA: 0x00165533 File Offset: 0x00163733
		static vtkOpenGLInstanceCulling()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOpenGLInstanceCulling.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLInstanceCulling"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060100BC RID: 65724 RVA: 0x0016555B File Offset: 0x0016375B
		public vtkOpenGLInstanceCulling(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060100BD RID: 65725
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLInstanceCulling_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100BE RID: 65726 RVA: 0x0016556C File Offset: 0x0016376C
		public new static vtkOpenGLInstanceCulling New()
		{
			vtkOpenGLInstanceCulling result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100BF RID: 65727 RVA: 0x001655C0 File Offset: 0x001637C0
		public vtkOpenGLInstanceCulling() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060100C0 RID: 65728 RVA: 0x00165604 File Offset: 0x00163804
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060100C1 RID: 65729
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLInstanceCulling_AddLOD_01(HandleRef pThis, float distance, float targetReduction);

		/// <summary>
		/// Add a level of detail.
		/// distance is the distance after which LOD is enabled
		/// targetReduction is the reduction factor applied on polydata (vtkDecimatePro is used)
		///
		/// @sa vtkDecimatePro::SetTargetReduction
		/// </summary>
		// Token: 0x060100C2 RID: 65730 RVA: 0x0016560F File Offset: 0x0016380F
		public void AddLOD(float distance, float targetReduction)
		{
			vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_AddLOD_01(base.GetCppThis(), distance, targetReduction);
		}

		// Token: 0x060100C3 RID: 65731
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkOpenGLInstanceCulling_GetColorLOD_02(HandleRef pThis);

		/// <summary>
		/// Overload color with unique color per LOD.
		/// </summary>
		// Token: 0x060100C4 RID: 65732 RVA: 0x00165620 File Offset: 0x00163820
		public virtual bool GetColorLOD()
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetColorLOD_02(base.GetCppThis()) != 0;
		}

		// Token: 0x060100C5 RID: 65733
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLInstanceCulling_GetHelper_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get helper structure.
		/// </summary>
		// Token: 0x060100C6 RID: 65734 RVA: 0x00165648 File Offset: 0x00163848
		public vtkOpenGLHelper GetHelper()
		{
			vtkOpenGLHelper result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetHelper_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLHelper)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060100C7 RID: 65735
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLInstanceCulling_GetLODBuffer_04(HandleRef pThis, long index, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the transform feedback buffer generated by the culling program.
		/// </summary>
		// Token: 0x060100C8 RID: 65736 RVA: 0x001656A4 File Offset: 0x001638A4
		public vtkOpenGLBufferObject GetLODBuffer(long index)
		{
			vtkOpenGLBufferObject vtkOpenGLBufferObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetLODBuffer_04(base.GetCppThis(), index, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLBufferObject = (vtkOpenGLBufferObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLBufferObject.Register(null);
				}
			}
			return vtkOpenGLBufferObject;
		}

		// Token: 0x060100C9 RID: 65737
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100CA RID: 65738 RVA: 0x00165714 File Offset: 0x00163914
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060100CB RID: 65739
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100CC RID: 65740 RVA: 0x00165734 File Offset: 0x00163934
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060100CD RID: 65741
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOpenGLInstanceCulling_GetNumberOfLOD_07(HandleRef pThis);

		/// <summary>
		/// Get number of LOD currently declared.
		/// </summary>
		// Token: 0x060100CE RID: 65742 RVA: 0x00165750 File Offset: 0x00163950
		public long GetNumberOfLOD()
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_GetNumberOfLOD_07(base.GetCppThis());
		}

		// Token: 0x060100CF RID: 65743
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLInstanceCulling_InitLOD_08(HandleRef pThis, HandleRef pd);

		/// <summary>
		/// Initialize LOD with a polydata
		/// </summary>
		// Token: 0x060100D0 RID: 65744 RVA: 0x00165770 File Offset: 0x00163970
		public void InitLOD(vtkPolyData pd)
		{
			vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_InitLOD_08(base.GetCppThis(), (pd == null) ? default(HandleRef) : pd.GetCppThis());
		}

		// Token: 0x060100D1 RID: 65745
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLInstanceCulling_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100D2 RID: 65746 RVA: 0x001657A0 File Offset: 0x001639A0
		public override int IsA(string type)
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x060100D3 RID: 65747
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOpenGLInstanceCulling_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100D4 RID: 65748 RVA: 0x001657C0 File Offset: 0x001639C0
		public new static int IsTypeOf(string type)
		{
			return vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_IsTypeOf_10(type);
		}

		// Token: 0x060100D5 RID: 65749
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLInstanceCulling_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100D6 RID: 65750 RVA: 0x001657DC File Offset: 0x001639DC
		public new vtkOpenGLInstanceCulling NewInstance()
		{
			vtkOpenGLInstanceCulling result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060100D7 RID: 65751
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLInstanceCulling_RunCullingShaders_13(HandleRef pThis, long numInstances, HandleRef matrixBuffer, HandleRef colorBuffer, HandleRef normalBuffer);

		/// <summary>
		/// Run the culling program and generate LOD buffers.
		/// </summary>
		// Token: 0x060100D8 RID: 65752 RVA: 0x00165838 File Offset: 0x00163A38
		public void RunCullingShaders(long numInstances, vtkOpenGLBufferObject matrixBuffer, vtkOpenGLBufferObject colorBuffer, vtkOpenGLBufferObject normalBuffer)
		{
			vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_RunCullingShaders_13(base.GetCppThis(), numInstances, (matrixBuffer == null) ? default(HandleRef) : matrixBuffer.GetCppThis(), (colorBuffer == null) ? default(HandleRef) : colorBuffer.GetCppThis(), (normalBuffer == null) ? default(HandleRef) : normalBuffer.GetCppThis());
		}

		// Token: 0x060100D9 RID: 65753
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOpenGLInstanceCulling_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060100DA RID: 65754 RVA: 0x00165894 File Offset: 0x00163A94
		public new static vtkOpenGLInstanceCulling SafeDownCast(vtkObjectBase o)
		{
			vtkOpenGLInstanceCulling vtkOpenGLInstanceCulling = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOpenGLInstanceCulling = (vtkOpenGLInstanceCulling)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOpenGLInstanceCulling.Register(null);
				}
			}
			return vtkOpenGLInstanceCulling;
		}

		// Token: 0x060100DB RID: 65755
		[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOpenGLInstanceCulling_SetColorLOD_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Overload color with unique color per LOD.
		/// </summary>
		// Token: 0x060100DC RID: 65756 RVA: 0x00165913 File Offset: 0x00163B13
		public virtual void SetColorLOD(bool _arg)
		{
			vtkOpenGLInstanceCulling.vtkOpenGLInstanceCulling_SetColorLOD_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B6 RID: 4790
		public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLInstanceCulling";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040012B7 RID: 4791
		public new static readonly string MRClassNameKey = "class vtkOpenGLInstanceCulling";
	}
}
