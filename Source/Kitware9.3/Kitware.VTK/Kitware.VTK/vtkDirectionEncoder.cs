using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDirectionEncoder
	/// </summary>
	/// <remarks>
	///    encode a direction into a one or two byte value
	///
	///
	/// Given a direction, encode it into an integer value. This value should
	/// be less than 65536, which is the maximum number of encoded directions
	/// supported by this superclass. A direction encoded is used to encode
	/// normals in a volume for use during volume rendering, and the
	/// amount of space that is allocated per normal is 2 bytes.
	/// This is an abstract superclass - see the subclasses for specific
	/// implementation details.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkRecursiveSphereDirectionEncoder
	/// </seealso>
	// Token: 0x02000391 RID: 913
	public abstract class vtkDirectionEncoder : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600A5F3 RID: 42483 RVA: 0x000EB8EF File Offset: 0x000E9AEF
		static vtkDirectionEncoder()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDirectionEncoder.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDirectionEncoder"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5F4 RID: 42484 RVA: 0x000EB917 File Offset: 0x000E9B17
		public vtkDirectionEncoder(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600A5F5 RID: 42485 RVA: 0x000EB925 File Offset: 0x000E9B25
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600A5F6 RID: 42486
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradient_01(HandleRef pThis, int value);

		/// <summary>
		/// / Given an encoded value, return a pointer to the normal vector
		/// </summary>
		// Token: 0x0600A5F7 RID: 42487 RVA: 0x000EB930 File Offset: 0x000E9B30
		public virtual float[] GetDecodedGradient(int value)
		{
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_GetDecodedGradient_01(base.GetCppThis(), value);
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600A5F8 RID: 42488
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectionEncoder_GetDecodedGradientTable_02(HandleRef pThis);

		/// <summary>
		/// Get the decoded gradient table. There are
		/// this-&gt;GetNumberOfEncodedDirections() entries in the table, each
		/// containing a normal (direction) vector. This is a flat structure -
		/// 3 times the number of directions floats in an array.
		/// </summary>
		// Token: 0x0600A5F9 RID: 42489 RVA: 0x000EB97C File Offset: 0x000E9B7C
		public virtual IntPtr GetDecodedGradientTable()
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetDecodedGradientTable_02(base.GetCppThis());
		}

		// Token: 0x0600A5FA RID: 42490
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectionEncoder_GetEncodedDirection_03(HandleRef pThis, IntPtr n);

		/// <summary>
		/// Given a normal vector n, return the encoded direction
		/// </summary>
		// Token: 0x0600A5FB RID: 42491 RVA: 0x000EB99C File Offset: 0x000E9B9C
		public virtual int GetEncodedDirection(IntPtr n)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetEncodedDirection_03(base.GetCppThis(), n);
		}

		// Token: 0x0600A5FC RID: 42492
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectionEncoder_GetNumberOfEncodedDirections_04(HandleRef pThis);

		/// <summary>
		/// Return the number of encoded directions
		/// </summary>
		// Token: 0x0600A5FD RID: 42493 RVA: 0x000EB9BC File Offset: 0x000E9BBC
		public virtual int GetNumberOfEncodedDirections()
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetNumberOfEncodedDirections_04(base.GetCppThis());
		}

		// Token: 0x0600A5FE RID: 42494
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectionEncoder_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A5FF RID: 42495 RVA: 0x000EB9DC File Offset: 0x000E9BDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0600A600 RID: 42496
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDirectionEncoder_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A601 RID: 42497 RVA: 0x000EB9FC File Offset: 0x000E9BFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0600A602 RID: 42498
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectionEncoder_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A603 RID: 42499 RVA: 0x000EBA18 File Offset: 0x000E9C18
		public override int IsA(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600A604 RID: 42500
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDirectionEncoder_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A605 RID: 42501 RVA: 0x000EBA38 File Offset: 0x000E9C38
		public new static int IsTypeOf(string type)
		{
			return vtkDirectionEncoder.vtkDirectionEncoder_IsTypeOf_08(type);
		}

		// Token: 0x0600A606 RID: 42502
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectionEncoder_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A607 RID: 42503 RVA: 0x000EBA54 File Offset: 0x000E9C54
		public new vtkDirectionEncoder NewInstance()
		{
			vtkDirectionEncoder result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600A608 RID: 42504
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDirectionEncoder_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the name of this class
		/// </summary>
		// Token: 0x0600A609 RID: 42505 RVA: 0x000EBAB0 File Offset: 0x000E9CB0
		public new static vtkDirectionEncoder SafeDownCast(vtkObjectBase o)
		{
			vtkDirectionEncoder vtkDirectionEncoder = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDirectionEncoder.vtkDirectionEncoder_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDirectionEncoder = (vtkDirectionEncoder)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDirectionEncoder.Register(null);
				}
			}
			return vtkDirectionEncoder;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D57 RID: 3415
		public new const string MRFullTypeName = "Kitware.VTK.vtkDirectionEncoder";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D58 RID: 3416
		public new static readonly string MRClassNameKey = "class vtkDirectionEncoder";
	}
}
