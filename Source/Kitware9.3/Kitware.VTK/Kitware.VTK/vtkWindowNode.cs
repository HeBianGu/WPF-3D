using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkWindowNode
	/// </summary>
	/// <remarks>
	///    vtkViewNode specialized for vtkRenderWindows
	///
	/// State storage and graph traversal for vtkRenderWindow
	/// </remarks>
	// Token: 0x02000220 RID: 544
	public class vtkWindowNode : vtkViewNode
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060066A5 RID: 26277 RVA: 0x00093F77 File Offset: 0x00092177
		static vtkWindowNode()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWindowNode.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWindowNode"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060066A6 RID: 26278 RVA: 0x00093F9F File Offset: 0x0009219F
		public vtkWindowNode(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060066A7 RID: 26279
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066A8 RID: 26280 RVA: 0x00093FB0 File Offset: 0x000921B0
		public new static vtkWindowNode New()
		{
			vtkWindowNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowNode.vtkWindowNode_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066A9 RID: 26281 RVA: 0x00094004 File Offset: 0x00092204
		public vtkWindowNode() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkWindowNode.vtkWindowNode_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060066AA RID: 26282 RVA: 0x00094048 File Offset: 0x00092248
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060066AB RID: 26283
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowNode_Build_01(HandleRef pThis, byte prepass);

		/// <summary>
		/// Build containers for our child nodes.
		/// </summary>
		// Token: 0x060066AC RID: 26284 RVA: 0x00094053 File Offset: 0x00092253
		public override void Build(bool prepass)
		{
			vtkWindowNode.vtkWindowNode_Build_01(base.GetCppThis(), prepass ? (byte)1 : (byte)0);
		}

		// Token: 0x060066AD RID: 26285
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_GetColorBuffer_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the most recent color buffer RGBA
		/// </summary>
		// Token: 0x060066AE RID: 26286 RVA: 0x0009406C File Offset: 0x0009226C
		public virtual vtkUnsignedCharArray GetColorBuffer()
		{
			vtkUnsignedCharArray vtkUnsignedCharArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowNode.vtkWindowNode_GetColorBuffer_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUnsignedCharArray = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUnsignedCharArray.Register(null);
				}
			}
			return vtkUnsignedCharArray;
		}

		// Token: 0x060066AF RID: 26287
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowNode_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066B0 RID: 26288 RVA: 0x000940DC File Offset: 0x000922DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkWindowNode.vtkWindowNode_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060066B1 RID: 26289
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkWindowNode_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066B2 RID: 26290 RVA: 0x000940FC File Offset: 0x000922FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkWindowNode.vtkWindowNode_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060066B3 RID: 26291
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_GetSize_05(HandleRef pThis);

		/// <summary>
		/// Return the size of the last rendered image
		/// </summary>
		// Token: 0x060066B4 RID: 26292 RVA: 0x00094118 File Offset: 0x00092318
		public virtual IntPtr GetSize()
		{
			return vtkWindowNode.vtkWindowNode_GetSize_05(base.GetCppThis());
		}

		// Token: 0x060066B5 RID: 26293
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_GetZBuffer_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the most recent zbuffer buffer
		/// </summary>
		// Token: 0x060066B6 RID: 26294 RVA: 0x00094138 File Offset: 0x00092338
		public virtual vtkFloatArray GetZBuffer()
		{
			vtkFloatArray vtkFloatArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowNode.vtkWindowNode_GetZBuffer_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFloatArray = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFloatArray.Register(null);
				}
			}
			return vtkFloatArray;
		}

		// Token: 0x060066B7 RID: 26295
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowNode_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066B8 RID: 26296 RVA: 0x000941A8 File Offset: 0x000923A8
		public override int IsA(string type)
		{
			return vtkWindowNode.vtkWindowNode_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x060066B9 RID: 26297
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkWindowNode_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066BA RID: 26298 RVA: 0x000941C8 File Offset: 0x000923C8
		public new static int IsTypeOf(string type)
		{
			return vtkWindowNode.vtkWindowNode_IsTypeOf_08(type);
		}

		// Token: 0x060066BB RID: 26299
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066BC RID: 26300 RVA: 0x000941E4 File Offset: 0x000923E4
		public new vtkWindowNode NewInstance()
		{
			vtkWindowNode result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowNode.vtkWindowNode_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060066BD RID: 26301
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkWindowNode_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060066BE RID: 26302 RVA: 0x00094240 File Offset: 0x00092440
		public new static vtkWindowNode SafeDownCast(vtkObjectBase o)
		{
			vtkWindowNode vtkWindowNode = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkWindowNode.vtkWindowNode_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWindowNode = (vtkWindowNode)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWindowNode.Register(null);
				}
			}
			return vtkWindowNode;
		}

		// Token: 0x060066BF RID: 26303
		[DllImport("Kitware.VTK.RenderingSceneGraph.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkWindowNode_Synchronize_12(HandleRef pThis, byte prepass);

		/// <summary>
		/// Get state of my renderable.
		/// </summary>
		// Token: 0x060066C0 RID: 26304 RVA: 0x000942BF File Offset: 0x000924BF
		public override void Synchronize(bool prepass)
		{
			vtkWindowNode.vtkWindowNode_Synchronize_12(base.GetCppThis(), prepass ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000927 RID: 2343
		public new const string MRFullTypeName = "Kitware.VTK.vtkWindowNode";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000928 RID: 2344
		public new static readonly string MRClassNameKey = "class vtkWindowNode";
	}
}
