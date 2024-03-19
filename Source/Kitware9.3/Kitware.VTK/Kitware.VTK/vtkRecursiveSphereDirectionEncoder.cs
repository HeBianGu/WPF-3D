using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRecursiveSphereDirectionEncoder
	/// </summary>
	/// <remarks>
	///    A direction encoder based on the recursive subdivision of an octahedron
	///
	/// vtkRecursiveSphereDirectionEncoder is a direction encoder which uses the
	/// vertices of a recursive subdivision of an octahedron (with the vertices
	/// pushed out onto the surface of an enclosing sphere) to encode directions
	/// into a two byte value.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDirectionEncoder
	/// </seealso>
	// Token: 0x020003A0 RID: 928
	public class vtkRecursiveSphereDirectionEncoder : vtkDirectionEncoder
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A909 RID: 43273 RVA: 0x000F008B File Offset: 0x000EE28B
		static vtkRecursiveSphereDirectionEncoder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecursiveSphereDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveSphereDirectionEncoder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A90A RID: 43274 RVA: 0x000F00B3 File Offset: 0x000EE2B3
		public vtkRecursiveSphereDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600A90B RID: 43275
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct the object. Initialize the index table which will be
		/// used to map the normal into a patch on the recursively subdivided
		/// sphere.
		/// </summary>
		// Token: 0x0600A90C RID: 43276 RVA: 0x000F00C4 File Offset: 0x000EE2C4
		public new static vtkRecursiveSphereDirectionEncoder New()
		{
			vtkRecursiveSphereDirectionEncoder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct the object. Initialize the index table which will be
		/// used to map the normal into a patch on the recursively subdivided
		/// sphere.
		/// </summary>
		// Token: 0x0600A90D RID: 43277 RVA: 0x000F0118 File Offset: 0x000EE318
		public vtkRecursiveSphereDirectionEncoder() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A90E RID: 43278 RVA: 0x000F015C File Offset: 0x000EE35C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A90F RID: 43279
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		/// <summary>
		/// / Given an encoded value, return a pointer to the normal vector
		/// </summary>
		// Token: 0x0600A910 RID: 43280 RVA: 0x000F0168 File Offset: 0x000EE368
		public override float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A911 RID: 43281
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		/// <summary>
		/// Get the decoded gradient table. There are
		/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
		/// containing a normal (direction) vector. This is a flat structure -
		/// 3 times the number of directions floats in an array.
		/// </summary>
		// Token: 0x0600A912 RID: 43282 RVA: 0x000F01B4 File Offset: 0x000EE3B4
		public override IntPtr GetDecodedGradientTable()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		// Token: 0x0600A913 RID: 43283
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Given a normal vector n, return the encoded direction
		/// </summary>
		// Token: 0x0600A914 RID: 43284 RVA: 0x000F01D4 File Offset: 0x000EE3D4
		public override int GetEncodedDirection(IntPtr n)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		// Token: 0x0600A915 RID: 43285
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		/// <summary>
		/// Return the number of encoded directions
		/// </summary>
		// Token: 0x0600A916 RID: 43286 RVA: 0x000F01F4 File Offset: 0x000EE3F4
		public override int GetNumberOfEncodedDirections()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		// Token: 0x0600A917 RID: 43287
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A918 RID: 43288 RVA: 0x000F0214 File Offset: 0x000EE414
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A919 RID: 43289
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A91A RID: 43290 RVA: 0x000F0234 File Offset: 0x000EE434
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A91B RID: 43291
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_07(HandleRef pThis);

		/// <summary>
		/// Set / Get the recursion depth for the subdivision. This
		/// indicates how many time one triangle on the initial 8-sided
		/// sphere model is replaced by four triangles formed by connecting
		/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
		/// with 6 unique vertices. The normals are the vectors from the
		/// sphere center through the vertices. The number of directions
		/// will be 11 since the four normals with 0 z values will be
		/// duplicated in the table - once with +0 values and the other
		/// time with -0 values, and an addition index will be used to
		/// represent the (0,0,0) normal. If we instead choose a recursion
		/// level of 6 (the maximum that can fit within 2 bytes) the number
		/// of directions is 16643, with 16386 unique directions and a
		/// zero normal.
		/// </summary>
		// Token: 0x0600A91C RID: 43292 RVA: 0x000F0250 File Offset: 0x000EE450
		public virtual int GetRecursionDepth()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepth_07(base.GetCppThis());
		}

		// Token: 0x0600A91D RID: 43293
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Set / Get the recursion depth for the subdivision. This
		/// indicates how many time one triangle on the initial 8-sided
		/// sphere model is replaced by four triangles formed by connecting
		/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
		/// with 6 unique vertices. The normals are the vectors from the
		/// sphere center through the vertices. The number of directions
		/// will be 11 since the four normals with 0 z values will be
		/// duplicated in the table - once with +0 values and the other
		/// time with -0 values, and an addition index will be used to
		/// represent the (0,0,0) normal. If we instead choose a recursion
		/// level of 6 (the maximum that can fit within 2 bytes) the number
		/// of directions is 16643, with 16386 unique directions and a
		/// zero normal.
		/// </summary>
		// Token: 0x0600A91E RID: 43294 RVA: 0x000F0270 File Offset: 0x000EE470
		public virtual int GetRecursionDepthMaxValue()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600A91F RID: 43295
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_09(HandleRef pThis);

		/// <summary>
		/// Set / Get the recursion depth for the subdivision. This
		/// indicates how many time one triangle on the initial 8-sided
		/// sphere model is replaced by four triangles formed by connecting
		/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
		/// with 6 unique vertices. The normals are the vectors from the
		/// sphere center through the vertices. The number of directions
		/// will be 11 since the four normals with 0 z values will be
		/// duplicated in the table - once with +0 values and the other
		/// time with -0 values, and an addition index will be used to
		/// represent the (0,0,0) normal. If we instead choose a recursion
		/// level of 6 (the maximum that can fit within 2 bytes) the number
		/// of directions is 16643, with 16386 unique directions and a
		/// zero normal.
		/// </summary>
		// Token: 0x0600A920 RID: 43296 RVA: 0x000F0290 File Offset: 0x000EE490
		public virtual int GetRecursionDepthMinValue()
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_GetRecursionDepthMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600A921 RID: 43297
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A922 RID: 43298 RVA: 0x000F02B0 File Offset: 0x000EE4B0
		public override int IsA(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600A923 RID: 43299
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveSphereDirectionEncoder_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A924 RID: 43300 RVA: 0x000F02D0 File Offset: 0x000EE4D0
		public new static int IsTypeOf(string type)
		{
			return vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_IsTypeOf_11(type);
		}

		// Token: 0x0600A925 RID: 43301
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A926 RID: 43302 RVA: 0x000F02EC File Offset: 0x000EE4EC
		public new vtkRecursiveSphereDirectionEncoder NewInstance()
		{
			vtkRecursiveSphereDirectionEncoder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A927 RID: 43303
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveSphereDirectionEncoder_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600A928 RID: 43304 RVA: 0x000F0348 File Offset: 0x000EE548
		public new static vtkRecursiveSphereDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkRecursiveSphereDirectionEncoder vtkRecursiveSphereDirectionEncoder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRecursiveSphereDirectionEncoder = (vtkRecursiveSphereDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRecursiveSphereDirectionEncoder.Register(null);
				}
			}
			return vtkRecursiveSphereDirectionEncoder;
		}

		// Token: 0x0600A929 RID: 43305
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the recursion depth for the subdivision. This
		/// indicates how many time one triangle on the initial 8-sided
		/// sphere model is replaced by four triangles formed by connecting
		/// triangle edge midpoints. A recursion level of 0 yields 8 triangles
		/// with 6 unique vertices. The normals are the vectors from the
		/// sphere center through the vertices. The number of directions
		/// will be 11 since the four normals with 0 z values will be
		/// duplicated in the table - once with +0 values and the other
		/// time with -0 values, and an addition index will be used to
		/// represent the (0,0,0) normal. If we instead choose a recursion
		/// level of 6 (the maximum that can fit within 2 bytes) the number
		/// of directions is 16643, with 16386 unique directions and a
		/// zero normal.
		/// </summary>
		// Token: 0x0600A92A RID: 43306 RVA: 0x000F03C7 File Offset: 0x000EE5C7
		public virtual void SetRecursionDepth(int _arg)
		{
			vtkRecursiveSphereDirectionEncoder.vtkRecursiveSphereDirectionEncoder_SetRecursionDepth_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D75 RID: 3445
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveSphereDirectionEncoder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D76 RID: 3446
		public new static readonly string MRClassNameKey = "class vtkRecursiveSphereDirectionEncoder";
	}
}
